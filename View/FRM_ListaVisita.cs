using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CompromisoSocial.Controlador;
using CompromisoSocial.Modelo;

namespace CompromisoSocial.View
{
    public partial class FRM_ListaVisita : Form
    {
        private VisitaController controller;

        public FRM_ListaVisita()
        {
            InitializeComponent();
            this.Load += ListaVisita_Load;
            controller = new VisitaController();
        }

        private void ListaVisita_Load(object sender, EventArgs e)
        {
            CargarVisita();
            EstilizarDataGridView();
            datebuscar.ValueChanged += datebuscar_ValueChanged;


        }

        private void CargarVisita()
        {
            var lista = controller.ObtenerVisitas();

            datagridListaVisita.DataSource = null;
            datagridListaVisita.AutoGenerateColumns = true;
            datagridListaVisita.DataSource = lista;
        }

        private void EstilizarDataGridView()
        {
            datagridListaVisita.EnableHeadersVisualStyles = false;

            // Encabezados
            datagridListaVisita.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            datagridListaVisita.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridListaVisita.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas
            datagridListaVisita.DefaultCellStyle.BackColor = Color.White;
            datagridListaVisita.DefaultCellStyle.ForeColor = Color.Black;
            datagridListaVisita.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            datagridListaVisita.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            datagridListaVisita.DefaultCellStyle.SelectionForeColor = Color.Black;

            datagridListaVisita.GridColor = Color.LightGray;
            datagridListaVisita.RowHeadersVisible = false;
            datagridListaVisita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void datagridListaVisita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridListaVisita.Rows[e.RowIndex];
                int valorColumna1 = Convert.ToInt32(row.Cells["idVisita"].Value);
                Visita user = controller.ObtenerVisitaPorId(valorColumna1);

                FRM_EditarVisita frmEditar = new FRM_EditarVisita(user);

                // Suscribirse al evento de actualización
                frmEditar.VisitaActualizado += (s, ev) =>
                {
                    CargarVisita(); // Refresca la lista al volver
                };

                frmEditar.ShowDialog();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagridListaVisita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                CargarVisita();
            }
            else
            {
                var resultados = controller.BuscarVisitasPorCedula(textoBusqueda);
                datagridListaVisita.DataSource = null;
                datagridListaVisita.AutoGenerateColumns = true;
                datagridListaVisita.DataSource = resultados;
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                CargarVisita();
            }
            else
            {
                var resultados = controller.BuscarVisitasPorCedula(textoBusqueda);
                datagridListaVisita.DataSource = null;
                datagridListaVisita.AutoGenerateColumns = true;
                datagridListaVisita.DataSource = resultados;
            }




        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void datebuscar_ValueChanged(object sender, EventArgs e)
        {


            DateTime fechaSeleccionada = datebuscar.Value.Date;
            var visitasFiltradas = controller.ObtenerVisitasPorFecha(fechaSeleccionada);

            datagridListaVisita.DataSource = null;
            datagridListaVisita.AutoGenerateColumns = true;
            datagridListaVisita.DataSource = visitasFiltradas;



        }
    }
}
