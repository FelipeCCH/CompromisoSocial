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
using CompromisoSocial.Modelo;

namespace CompromisoSocial.View
{
    public partial class FRM_RegistroVisita : Form
    {
        public FRM_RegistroVisita()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            VisitaController controller = new VisitaController();
            var visitas = controller.ObtenerVisitas();

            if (visitas == null || visitas.Count == 0)
            {
                MessageBox.Show("⚠️ No existen registros de visitas. Por favor agrega una.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            FRM_ListaVisita listaUsuario = new FRM_ListaVisita();
            listaUsuario.ShowDialog(); // ✅ Esto sí fuerza que cargue correctamente


        }

        private void FRM_RegistroUsuario_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            dtFechaSalida.Value = DateTime.Now.AddHours(1);
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtDestino.Clear();
            txtAsunto.Clear();
            dtFechaSalida.Value = DateTime.Now.AddHours(1); // valor sugerido
        }


        private void btnAceptar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
               string.IsNullOrWhiteSpace(txtNombre.Text) ||
              string.IsNullOrWhiteSpace(txtDestino.Text) ||
             string.IsNullOrWhiteSpace(txtAsunto.Text))
            {
                MessageBox.Show("⚠️ Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtFechaSalida.Value <= DateTime.Now)
            {
                MessageBox.Show("⚠️ La fecha de salida debe ser posterior a la fecha actual.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Visita nuevaVisita = new Visita
            {
                idUsuario = SesionActual.IdUsuario, // 🔧 Ajustá esto si usás login
                cedula = txtCedula.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                destino = txtDestino.Text.Trim(),
                asunto = txtAsunto.Text.Trim(),
                fechaIngreso = DateTime.Now,
                fechaSalida = dtFechaSalida.Value
            };

            VisitaController controller = new VisitaController();
            bool guardado = controller.InsertarVisita(nuevaVisita);

            if (guardado)
            {
                MessageBox.Show("Visita registrada exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("❌ No se pudo registrar la visita.");
            }
        }

        private void btnVolverRUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}