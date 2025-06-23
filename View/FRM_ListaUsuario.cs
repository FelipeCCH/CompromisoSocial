using System;
using System.Drawing;
using System.Windows.Forms;
using CompromisoSocial.Controlador;
using CompromisoSocial.Modelo;

namespace CompromisoSocial.View
{
    public partial class FRM_ListaUsuario : Form
    {
        private UsuarioController controller;

        public FRM_ListaUsuario()
        {
            InitializeComponent();
            this.Load += ListaUsuario_Load;
            controller = new UsuarioController();
        }

        private void ListaUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            EstilizarDataGridView();
        }

        private void CargarUsuarios()
        {
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


        private void datagridListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridListaUsuario.Rows[e.RowIndex];
                int valorColumna1 = Convert.ToInt32(row.Cells["IdUsuario"].Value);
                Usuario user = controller.ObtenerUsuarioPorId(valorColumna1);

                FRM_EditarUsuario frmEditar = new FRM_EditarUsuario(user);

                // Suscribirse al evento de actualización
                frmEditar.UsuarioActualizado += (s, ev) =>
                {
                    CargarUsuarios(); // Refresca la lista al volver
                };

                frmEditar.ShowDialog();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
