namespace CompromisoSocial.View
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.correoElectronico = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hashicon = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashicon)).BeginInit();
            this.SuspendLayout();
            // 
            // correoElectronico
            // 
            this.correoElectronico.AutoSize = true;
            this.correoElectronico.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoElectronico.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.correoElectronico.Location = new System.Drawing.Point(38, 115);
            this.correoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.Size = new System.Drawing.Size(136, 15);
            this.correoElectronico.TabIndex = 0;
            this.correoElectronico.Text = "Correo eléctronico";
            this.correoElectronico.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.hashicon);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Controls.Add(this.correoElectronico);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(44, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 409);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hashicon
            // 
            this.hashicon.Image = ((System.Drawing.Image)(resources.GetObject("hashicon.Image")));
            this.hashicon.Location = new System.Drawing.Point(223, 214);
            this.hashicon.Name = "hashicon";
            this.hashicon.Size = new System.Drawing.Size(32, 30);
            this.hashicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hashicon.TabIndex = 15;
            this.hashicon.TabStop = false;
            this.hashicon.Click += new System.EventHandler(this.hashicon_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresar.Location = new System.Drawing.Point(40, 280);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(186, 27);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesión";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(40, 222);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(187, 22);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Location = new System.Drawing.Point(40, 139);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 30);
            this.txtCorreo.TabIndex = 2;
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.contraseña.Location = new System.Drawing.Point(38, 206);
            this.contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(82, 15);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Contraseña";
            this.contraseña.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(492, 536);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Login";
            this.Text = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label correoElectronico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox hashicon;
    }
}