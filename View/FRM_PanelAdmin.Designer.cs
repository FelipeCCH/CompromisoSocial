using System.Drawing;

namespace CompromisoSocial.View
{
    partial class FRM_PanelAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PanelAdmin));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pnlListasSubmenu = new System.Windows.Forms.Panel();
            this.btnListaVisitas = new System.Windows.Forms.Button();
            this.btnListaUsuarios = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRegistroSubmenu = new System.Windows.Forms.Panel();
            this.btnRegistroVisita = new System.Windows.Forms.Button();
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.pnlListasSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRegistroSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.sidebar.Controls.Add(this.btnSalir);
            this.sidebar.Controls.Add(this.panel1);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.pnlListasSubmenu);
            this.panel1.Controls.Add(this.btnVisitas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnlRegistroSubmenu);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pnlListasSubmenu
            // 
            this.pnlListasSubmenu.Controls.Add(this.btnListaVisitas);
            this.pnlListasSubmenu.Controls.Add(this.btnListaUsuarios);
            resources.ApplyResources(this.pnlListasSubmenu, "pnlListasSubmenu");
            this.pnlListasSubmenu.Name = "pnlListasSubmenu";
            // 
            // btnListaVisitas
            // 
            resources.ApplyResources(this.btnListaVisitas, "btnListaVisitas");
            this.btnListaVisitas.ForeColor = System.Drawing.Color.White;
            this.btnListaVisitas.Name = "btnListaVisitas";
            this.btnListaVisitas.UseVisualStyleBackColor = true;
            this.btnListaVisitas.Click += new System.EventHandler(this.btnListaVisitas_Click);
            // 
            // btnListaUsuarios
            // 
            resources.ApplyResources(this.btnListaUsuarios, "btnListaUsuarios");
            this.btnListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnListaUsuarios.Name = "btnListaUsuarios";
            this.btnListaUsuarios.UseVisualStyleBackColor = true;
            this.btnListaUsuarios.Click += new System.EventHandler(this.btnListaUsuarios_Click);
            // 
            // btnVisitas
            // 
            resources.ApplyResources(this.btnVisitas, "btnVisitas");
            this.btnVisitas.FlatAppearance.BorderSize = 0;
            this.btnVisitas.ForeColor = System.Drawing.Color.White;
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.UseVisualStyleBackColor = true;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pnlRegistroSubmenu
            // 
            this.pnlRegistroSubmenu.Controls.Add(this.btnRegistroVisita);
            this.pnlRegistroSubmenu.Controls.Add(this.btnRegistroUsuarios);
            resources.ApplyResources(this.pnlRegistroSubmenu, "pnlRegistroSubmenu");
            this.pnlRegistroSubmenu.Name = "pnlRegistroSubmenu";
            // 
            // btnRegistroVisita
            // 
            resources.ApplyResources(this.btnRegistroVisita, "btnRegistroVisita");
            this.btnRegistroVisita.ForeColor = System.Drawing.Color.White;
            this.btnRegistroVisita.Name = "btnRegistroVisita";
            this.btnRegistroVisita.UseVisualStyleBackColor = true;
            this.btnRegistroVisita.Click += new System.EventHandler(this.btnRegistroVisita_Click);
            // 
            // btnRegistroUsuarios
            // 
            resources.ApplyResources(this.btnRegistroUsuarios, "btnRegistroUsuarios");
            this.btnRegistroUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = true;
            this.btnRegistroUsuarios.Click += new System.EventHandler(this.btnRegistroUsuarios_Click);
            // 
            // btnRegistro
            // 
            resources.ApplyResources(this.btnRegistro, "btnRegistro");
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::CompromisoSocial.Properties.Resources.background;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // FRM_PanelAdmin
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sidebar);
            this.MaximizeBox = false;
            this.Name = "FRM_PanelAdmin";
            this.Load += new System.EventHandler(this.FRM_PanelAdmin_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.pnlListasSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRegistroSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisitas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRegistroSubmenu;
        private System.Windows.Forms.Button btnRegistroVisita;
        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.Panel pnlListasSubmenu;
        private System.Windows.Forms.Button btnListaVisitas;
        private System.Windows.Forms.Button btnListaUsuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
