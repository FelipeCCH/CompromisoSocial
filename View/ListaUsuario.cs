using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAcceso.Controlador;

namespace CompromisoSocial.View
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();

            this.Shown += ListaUsuario_Shown;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaUsuario_Load(object sender, EventArgs e)
        {



            CargarUsuarios();

        }

        private void ListaUsuario_Shown(object sender, EventArgs e)
        {
            CargarUsuarios();
        }




        private void datagridListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CargarUsuarios()
        {
            UsuarioController controller = new UsuarioController();
            var lista = controller.ObtenerUsuarios();

            datagridListaUsuario.AutoGenerateColumns = true;
            datagridListaUsuario.DataSource = null;
            datagridListaUsuario.DataSource = lista;

            // Forzar refresco visual del DGV
            datagridListaUsuario.Invalidate();
            datagridListaUsuario.Update();
            datagridListaUsuario.Refresh();

            // Forzar refresco del formulario completo
            this.Invalidate();
            this.Update();
            this.Refresh();

            // Estilo mínimo forzado
            datagridListaUsuario.DefaultCellStyle.ForeColor = Color.Black;
            datagridListaUsuario.DefaultCellStyle.BackColor = Color.White;
            datagridListaUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datagridListaUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            datagridListaUsuario.EnableHeadersVisualStyles = false;
        }

        private void datagridListaUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
