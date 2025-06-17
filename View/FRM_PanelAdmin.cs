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

    public partial class FRM_PanelAdmin : Form
    { 
        
        // Variables para controlar animación
    private bool expandiendo = false;
    private int sidebarWidth; // Valor original del ancho
    private int sidebarTarget; // Valor final al expandir o colapsar
    private int sidebarStep = 20; // Velocidad del cambio de ancho


        public FRM_PanelAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebar.Visible = true; // Asegúrate de que el sidebar esté visible antes de animar
            expandiendo = true;
            sidebarTarget = 200; // Cambia este valor según el ancho expandido deseado
            timer1.Start();



        }

        private void close_Click(object sender, EventArgs e)
        {

            expandiendo = false;
            sidebarTarget = 0; // Cerrar completamente
            timer1.Start();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (expandiendo)
            {
                if (sidebar.Width < sidebarTarget)
                {
                    sidebar.Width += sidebarStep;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (sidebar.Width > sidebarTarget)
                {
                    sidebar.Width -= sidebarStep;
                }
                else
                {
                    timer1.Stop();
                }
            }


        }

        private void FRM_PanelAdmin_Load(object sender, EventArgs e)
        {

            sidebarWidth = sidebar.Width; // Ancho actual (visible)
            sidebarTarget = sidebarWidth;



        }

        private void Administrador_Click(object sender, EventArgs e)
        {

            FRM_RegistroUsuario registroUsuario = new FRM_RegistroUsuario();
            registroUsuario.ShowDialog(); // Muestra el formulario de registro de usuario

        }
    }
}
