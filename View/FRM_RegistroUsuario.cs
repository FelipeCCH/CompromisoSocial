using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompromisoSocial.Controlador;
using CompromisoSocial.Modelo;

namespace CompromisoSocial.View
{
    public partial class FRM_RegistroUsuario : Form
    {
        public FRM_RegistroUsuario()
        {
            InitializeComponent();
            cboRol.SelectedIndex = 0;

            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            UsuarioController controller = new UsuarioController();
            var usuarios = controller.ObtenerUsuarios();

            if (usuarios == null || usuarios.Count == 0)
            {
                MessageBox.Show("⚠️ No existen registros de usuarios. Por favor agrega uno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           


            ListaUsuario listaUsuario = new ListaUsuario();
            listaUsuario.ShowDialog(); // ✅ Esto sí fuerza que cargue correctamente


        }

        private void FRM_RegistroUsuario_Load(object sender, EventArgs e)
        {


        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            Nombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtClave.Clear();
            cboRol.SelectedIndex = 0;
        }


        private void btnAceptar(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Nombre.Text) ||
            string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text) ||
            string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("⚠️ Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("⚠️ El formato del correo es inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("⚠️ El teléfono debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }







            Usuario nuevoUsuario = new Usuario
            {
                nombre = Nombre.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                telefono = int.Parse(txtTelefono.Text.Trim()),
                clave = txtClave.Text.Trim(),
                rol = cboRol.SelectedItem.ToString()
            };

            UsuarioController controller = new UsuarioController();
            bool guardado = controller.InsertarUsuario(nuevoUsuario);

            if (guardado)
            {
                MessageBox.Show("Usuario guardado exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el usuario.");
            }
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverRUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private string hashclave(string clave)
        //{
        //    using (var sha = system.security.cryptography.sha256.create())
        //    {
        //        var bytes = encoding.utf8.getbytes(clave);
        //        var hash = sha.computehash(bytes);
        //        return convert.tobase64string(hash);
        //    }
        //}

        private void chkMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
           // txtClave.UseSystemPasswordChar = !chkMostrarClave.Checked;
        }




    }
}