using CompromisoSocial.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompromisoSocial.View
{
    public partial class ListaVisitante : Form
    {
        public ListaVisitante()
        {
            InitializeComponent();
            this.Load += ListaVisitante_Load;
        }

        private void ListaVisitante_Load(object sender, EventArgs e)
        {
            CargarVisitantes();
            EstilizarDataGridView();
        }

        private void CargarVisitantes()
        {
            var controller = new VisitanteController();
            var lista = controller.ObtenerVisitantes();

            datagridListaVisitante.DataSource = null;
            datagridListaVisitante.AutoGenerateColumns = true;
            datagridListaVisitante.DataSource = lista;
        }

        private void EstilizarDataGridView()
        {
            datagridListaVisitante.EnableHeadersVisualStyles = false;

            // Encabezados
            datagridListaVisitante.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            datagridListaVisitante.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridListaVisitante.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas
            datagridListaVisitante.DefaultCellStyle.BackColor = Color.White;
            datagridListaVisitante.DefaultCellStyle.ForeColor = Color.Black;
            datagridListaVisitante.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            datagridListaVisitante.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            datagridListaVisitante.DefaultCellStyle.SelectionForeColor = Color.Black;

            datagridListaVisitante.GridColor = Color.LightGray;
            datagridListaVisitante.RowHeadersVisible = false;
            datagridListaVisitante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void datagridListaVisitante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hizo clic en el encabezado de la columna
            {
                DataGridViewRow row = datagridListaVisitante.SelectedRows[0];
                // Aquí puedes acceder a los datos de la fila seleccionada
                string valorColumna1 = row.Cells["nombre"].Value.ToString();
                // ...
                MessageBox.Show(valorColumna1);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
