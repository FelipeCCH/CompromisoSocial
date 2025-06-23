using CompromisoSocial.Controlador;
using CompromisoSocial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompromisoSocial.View
{
    public partial class FRM_EditarVisita : Form
    {
        private Visita visitaActual;
        private VisitaController controller;

        // Evento para notificar actualización
        public event EventHandler VisitaActualizado;

        public FRM_EditarVisita(Visita visita)
        {
            InitializeComponent();
            visitaActual = visita;
            controller = new VisitaController();
        }

        private void FRM_EditarRegistro_Load(object sender, EventArgs e)
        {
            if (visitaActual != null)
            {
                txtIdVisita.Text = visitaActual.idVisita.ToString();
                txtCedula.Text = visitaActual.cedula;
                txtNombre.Text = visitaActual.nombre;
                txtDestino.Text = visitaActual.destino;
                txtAsunto.Text = visitaActual.asunto;

                dtFechaEntrada.Value = visitaActual.fechaIngreso;
                dtFechaSalida.Value = visitaActual.fechaSalida;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDestino.Text) ||
                string.IsNullOrWhiteSpace(txtAsunto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos del objeto visita
            visitaActual.cedula = txtCedula.Text.Trim();
            visitaActual.nombre = txtNombre.Text.Trim();
            visitaActual.destino = txtDestino.Text.Trim();
            visitaActual.asunto = txtAsunto.Text.Trim();
            visitaActual.fechaIngreso = dtFechaEntrada.Value;
            visitaActual.fechaSalida = dtFechaSalida.Value;

            bool actualizado = controller.ActualizarVisita(visitaActual.idVisita, visitaActual);

            if (actualizado)
            {
                MessageBox.Show("Visita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VisitaActualizado?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la visita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idVisita = Convert.ToInt32(txtIdVisita.Text);

            FRM_EliminarVisita frmEliminar = new FRM_EliminarVisita(idVisita); // Asumiendo que este form ya existe

            frmEliminar.VisitaEliminada += (s, ev) =>
            {
                VisitaActualizado?.Invoke(this, EventArgs.Empty);
                this.Close();
            };

            frmEliminar.ShowDialog();
        }
    }
}
