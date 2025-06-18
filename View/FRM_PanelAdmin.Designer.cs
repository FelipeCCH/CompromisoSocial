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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.sidebar.Controls.Add(this.btnSalir);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Name = "sidebar";
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnVisitas);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.close);
            this.panel2.Name = "panel2";
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menu.Name = "menu";
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_PanelAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.sidebar);
            this.MaximizeBox = false;
            this.Name = "FRM_PanelAdmin";
            this.Load += new System.EventHandler(this.FRM_PanelAdmin_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisitas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
