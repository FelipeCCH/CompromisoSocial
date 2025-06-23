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
    public partial class FRM_EliminarUsuario : Form
    {
        int idUsuarioactual;

        public event EventHandler UsuarioEliminado;

        public FRM_EliminarUsuario(int idUsuario)
        {
            InitializeComponent();
            idUsuarioactual = idUsuario;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();

            bool eliminado = controller.EliminarUsuario(idUsuarioactual);

            if (eliminado)
            {
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioEliminado?.Invoke(this, EventArgs.Empty); // Notifica al formulario padre si lo usás
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
