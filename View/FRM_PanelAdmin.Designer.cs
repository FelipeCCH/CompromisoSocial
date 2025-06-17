namespace CompromisoSocial.View
{
    partial class FRM_PanelAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PanelAdmin));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.Usurios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Administrador = new System.Windows.Forms.Button();
            this.visitante = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Salir = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.sidebar.Controls.Add(this.Salir);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(223, 450);
            this.sidebar.TabIndex = 0;
            this.sidebar.Visible = false;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 73);
            this.panel2.TabIndex = 1;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(223, 23);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usurios
            // 
            this.Usurios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Usurios.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Usurios.FlatAppearance.BorderSize = 0;
            this.Usurios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usurios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usurios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usurios.Location = new System.Drawing.Point(0, 23);
            this.Usurios.Name = "Usurios";
            this.Usurios.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.Usurios.Size = new System.Drawing.Size(223, 23);
            this.Usurios.TabIndex = 3;
            this.Usurios.Text = "Usuarios";
            this.Usurios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usurios.UseVisualStyleBackColor = true;
            this.Usurios.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visitante);
            this.panel1.Controls.Add(this.Administrador);
            this.panel1.Controls.Add(this.Usurios);
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 117);
            this.panel1.TabIndex = 4;
            // 
            // Administrador
            // 
            this.Administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Administrador.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Administrador.FlatAppearance.BorderSize = 0;
            this.Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Administrador.Location = new System.Drawing.Point(0, 46);
            this.Administrador.Name = "Administrador";
            this.Administrador.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.Administrador.Size = new System.Drawing.Size(223, 23);
            this.Administrador.TabIndex = 4;
            this.Administrador.Text = "Administrador";
            this.Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.UseVisualStyleBackColor = true;
            // 
            // visitante
            // 
            this.visitante.Dock = System.Windows.Forms.DockStyle.Top;
            this.visitante.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.visitante.FlatAppearance.BorderSize = 0;
            this.visitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitante.Location = new System.Drawing.Point(0, 69);
            this.visitante.Name = "visitante";
            this.visitante.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.visitante.Size = new System.Drawing.Size(223, 23);
            this.visitante.TabIndex = 5;
            this.visitante.Text = "Visitantes";
            this.visitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitante.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(-1, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(42, 34);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(143, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 32);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Salir
            // 
            this.Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir.Location = new System.Drawing.Point(0, 390);
            this.Salir.Name = "Salir";
            this.Salir.Padding = new System.Windows.Forms.Padding(15, 0, 35, 0);
            this.Salir.Size = new System.Drawing.Size(223, 60);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // FRM_PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.sidebar);
            this.Name = "FRM_PanelAdmin";
            this.Text = "FRM_PanelAdmin";
            this.Load += new System.EventHandler(this.FRM_PanelAdmin_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button Usurios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button visitante;
        private System.Windows.Forms.Button Administrador;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Salir;
    }
}