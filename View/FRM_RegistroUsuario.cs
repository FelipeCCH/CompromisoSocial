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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


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
    }
}