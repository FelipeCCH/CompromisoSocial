using System;
using System.Drawing;
using System.Windows.Forms;

namespace CompromisoSocial.View
{
    public partial class FRM_PanelAdmin : Form
    {
        private bool expandiendo = false;
        private int sidebarTarget = 200;

        public FRM_PanelAdmin()
        {
            InitializeComponent();
            //EstilizarSubmenus();

            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void FRM_PanelAdmin_Load(object sender, EventArgs e)
        {
            sidebar.Width = 200;
            sidebar.Visible = false;
        }
        private void OcultarSubMenus()
        {
            pnlRegistroSubmenu.Visible = false;
            pnlListasSubmenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (sidebar.Width == 0)
            {
                sidebar.Visible = true;
                expandiendo = true;
                sidebarTarget = 200;
            }
            else
            {
                expandiendo = false;
                sidebarTarget = 0;
            }

            timer1.Start();
        }

        private void ToggleSubMenu(Panel submenu)
        {
            // Cierra todos
            //panelRegistroSubmenu.Visible = false;
            //panelListasSubmenu.Visible = false;

            // Abre el que se seleccionó
            submenu.Visible = true;
        }


        private void close_Click(object sender, EventArgs e)
        {
            expandiendo = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int step = 50;

            if (expandiendo)
            {
                if (sidebar.Width < sidebarTarget)
                    sidebar.Width += step;
                else
                    timer1.Stop();
            }
            else
            {
                if (sidebar.Width > 0)
                    sidebar.Width -= step;
                else
                {
                    timer1.Stop();
                    sidebar.Visible = false;
                }
            }
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlRegistroSubmenu);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ir al dashboard principal");
        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlListasSubmenu);
        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            var form = new FRM_RegistroUsuario();
            form.ShowDialog();
        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            var form = new FRM_ListaUsuario();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaVisitantes_Click(object sender, EventArgs e)
        {
            var form = new ListaVisitante();
            form.ShowDialog();
        }
    }
}
