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

namespace CompromisoSocial.View
{
    public partial class FRM_EliminarVisita : Form
    {
        int idVisitaactual;

        public event EventHandler VisitaEliminada;

        public FRM_EliminarVisita(int idVisita)
        {
            InitializeComponent();
            idVisitaactual = idVisita;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VisitaController controller = new VisitaController();

            bool eliminado = controller.EliminarVisita(idVisitaactual);

            if (eliminado)
            {
                MessageBox.Show("Visita eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VisitaEliminada?.Invoke(this, EventArgs.Empty); // Notifica al formulario padre si lo usás
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar la Visita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_EliminarVisita_Load(object sender, EventArgs e)
        {

        }
    }
}
