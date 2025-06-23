using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompromisoSocial.Controlador;

namespace CompromisoSocial.View
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) )
            {
                MessageBox.Show("⚠️ Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("⚠️ El formato del correo es inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correo = txtCorreo.Text.Trim();
            string clave = HashClave(txtContrasena.Text.Trim());

            UsuarioController controller = new UsuarioController();
            var usuario = controller.VerificarLogin(correo, clave);

            if (usuario != null && usuario.rol == "Director")
            {
                FRM_PanelAdmin panel = new FRM_PanelAdmin();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Acceso denegado. Verifique sus credenciales o su rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {


         


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            txtContrasena.UseSystemPasswordChar = true;
            string ruta = Path.Combine(Application.StartupPath, "img", "closeicon.png");
            if (File.Exists(ruta))
            {
                hashicon.Image = Image.FromFile(ruta);
            }
            else
            {
                MessageBox.Show("No se encontró closeicon.png en la carpeta img");
            }

        }
        private string HashClave(string clave)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(clave);
                byte[] hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower(); // igual que el del controller
            }
        }



        bool mostrar = false;

        private void hashicon_Click(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            txtContrasena.UseSystemPasswordChar = !mostrar;

            string nombreImagen = mostrar ? "openicon.png" : "closeicon.png";
            string ruta = Path.Combine(Application.StartupPath, "img", nombreImagen);

            if (File.Exists(ruta))
            {
                hashicon.Image = Image.FromFile(ruta);
            }
            else
            {
                MessageBox.Show("❌ No se encontró la imagen: " + ruta);
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
