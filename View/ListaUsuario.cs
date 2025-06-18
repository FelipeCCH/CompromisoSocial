using System;
using System.Drawing;
using System.Windows.Forms;
using EduAcceso.Controlador;

namespace CompromisoSocial.View
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();
            this.Load += ListaUsuario_Load;
        }

        private void ListaUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            EstilizarDataGridView();
        }

        private void CargarUsuarios()
        {
            var controller = new UsuarioController();
            var lista = controller.ObtenerUsuarios();

            datagridListaUsuario.DataSource = null;
            datagridListaUsuario.AutoGenerateColumns = true;
            datagridListaUsuario.DataSource = lista;
        }

        private void EstilizarDataGridView()
        {
            datagridListaUsuario.EnableHeadersVisualStyles = false;

            // Encabezados
            datagridListaUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            datagridListaUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridListaUsuario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas
            datagridListaUsuario.DefaultCellStyle.BackColor = Color.White;
            datagridListaUsuario.DefaultCellStyle.ForeColor = Color.Black;
            datagridListaUsuario.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            datagridListaUsuario.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            datagridListaUsuario.DefaultCellStyle.SelectionForeColor = Color.Black;

            datagridListaUsuario.GridColor = Color.LightGray;
            datagridListaUsuario.RowHeadersVisible = false;
            datagridListaUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Acción del botón cerrar (btnCerrar)
            this.Close();
        }

        private void datagridListaUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Acción si se hace clic en una celda (puedes dejarlo vacío por ahora)
        }

    }
}
