using CompromisoSocial.Controlador;
using CompromisoSocial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompromisoSocial.View
{
    public partial class FRM_EditarUsuario : Form
    {
        private Usuario usuarioActual;
        private UsuarioController controller;

        // Evento para notificar actualización
        public event EventHandler UsuarioActualizado;

        public FRM_EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            controller = new UsuarioController();
        }

        private void FRM_EditarRegistro_Load(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                txtIdUsuario.Text = usuarioActual.idUsuario.ToString();
                txtNombre.Text = usuarioActual.nombre;
                txtCorreo.Text = usuarioActual.correo;
                txtTelefono.Text = usuarioActual.telefono.ToString();
                txtClave.Text = usuarioActual.clave;

                // Asegúrate de que los valores posibles ya estén cargados en el ComboBox
                cbRol.SelectedItem = usuarioActual.rol;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                cbRol.SelectedItem.ToString() == "Seleccione un rol")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el teléfono sea numérico
            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El teléfono debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos del objeto
            usuarioActual.nombre = txtNombre.Text.Trim();
            usuarioActual.correo = txtCorreo.Text.Trim();
            usuarioActual.telefono = telefono;
            usuarioActual.clave = HashClave(txtClave.Text.Trim());

            usuarioActual.rol = cbRol.SelectedItem.ToString();

            bool actualizado = controller.ActualizarUsuario(usuarioActual);

            if (actualizado)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioActualizado?.Invoke(this, EventArgs.Empty); // Notificar al formulario padre
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idusuario = Convert.ToInt32(txtIdUsuario.Text);


            FRM_EliminarUsuario frmEliminar = new FRM_EliminarUsuario(idusuario);

            // Escuchar el evento de eliminación para cerrar esta ventana y notificar
            frmEliminar.UsuarioEliminado += (s, ev) =>
            {
                UsuarioActualizado?.Invoke(this, EventArgs.Empty); // Notificar a la lista principal que se actualice
                this.Close(); // Cerrar la ventana actual de edición
            };

            frmEliminar.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private string HashClave(string clave)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(clave);
                byte[] hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }



    }
}
