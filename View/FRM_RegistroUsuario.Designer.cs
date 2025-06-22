namespace CompromisoSocial.View
{
    partial class FRM_RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RegistroUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hashicon = new System.Windows.Forms.PictureBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.btnVolverRUsuario = new System.Windows.Forms.Button();
            this.btnAceptarRUsuario = new System.Windows.Forms.Button();
            this.btnVerRUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hashicon);
            this.panel1.Controls.Add(this.cboRol);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbClave);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.lbCorreo);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(39, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 429);
            this.panel1.TabIndex = 0;
            // 
            // hashicon
            // 
            this.hashicon.Image = ((System.Drawing.Image)(resources.GetObject("hashicon.Image")));
            this.hashicon.Location = new System.Drawing.Point(263, 290);
            this.hashicon.Name = "hashicon";
            this.hashicon.Size = new System.Drawing.Size(25, 26);
            this.hashicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hashicon.TabIndex = 12;
            this.hashicon.TabStop = false;
            this.hashicon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboRol.Items.AddRange(new object[] {
            "Seleccione un rol",
            "Director",
            "Administrador Principal",
            "Administrador Secundario"});
            this.cboRol.Location = new System.Drawing.Point(56, 352);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(203, 21);
            this.cboRol.TabIndex = 1;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitulo.Location = new System.Drawing.Point(40, 37);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(248, 25);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Registrar Nuevo Usuario";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbClave.Location = new System.Drawing.Point(56, 268);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(144, 19);
            this.lbClave.TabIndex = 9;
            this.lbClave.Text = "Digite su contraseña";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTelefono.Location = new System.Drawing.Point(56, 211);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(68, 19);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRol.Location = new System.Drawing.Point(56, 330);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(112, 19);
            this.lbRol.TabIndex = 6;
            this.lbRol.Text = "Seleccionar Rol";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbCorreo.Location = new System.Drawing.Point(52, 149);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(56, 19);
            this.lbCorreo.TabIndex = 5;
            this.lbCorreo.Text = "Correo";
            this.lbCorreo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNombre.Location = new System.Drawing.Point(52, 85);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(67, 19);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(56, 171);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(203, 26);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(56, 290);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(203, 29);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(56, 233);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(203, 26);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(56, 107);
            this.Nombre.Multiline = true;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(203, 26);
            this.Nombre.TabIndex = 0;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // btnVolverRUsuario
            // 
            this.btnVolverRUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnVolverRUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverRUsuario.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverRUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverRUsuario.Location = new System.Drawing.Point(39, 487);
            this.btnVolverRUsuario.Name = "btnVolverRUsuario";
            this.btnVolverRUsuario.Size = new System.Drawing.Size(68, 27);
            this.btnVolverRUsuario.TabIndex = 12;
            this.btnVolverRUsuario.Text = "Volver";
            this.btnVolverRUsuario.UseVisualStyleBackColor = false;
            this.btnVolverRUsuario.Click += new System.EventHandler(this.btnVolverRUsuario_Click);
            // 
            // btnAceptarRUsuario
            // 
            this.btnAceptarRUsuario.BackColor = System.Drawing.Color.Green;
            this.btnAceptarRUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarRUsuario.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarRUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptarRUsuario.Location = new System.Drawing.Point(112, 487);
            this.btnAceptarRUsuario.Name = "btnAceptarRUsuario";
            this.btnAceptarRUsuario.Size = new System.Drawing.Size(88, 27);
            this.btnAceptarRUsuario.TabIndex = 13;
            this.btnAceptarRUsuario.Text = "Aceptar";
            this.btnAceptarRUsuario.UseVisualStyleBackColor = false;
            this.btnAceptarRUsuario.Click += new System.EventHandler(this.btnAceptar);
            // 
            // btnVerRUsuarios
            // 
            this.btnVerRUsuarios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerRUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRUsuarios.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerRUsuarios.Location = new System.Drawing.Point(235, 487);
            this.btnVerRUsuarios.Name = "btnVerRUsuarios";
            this.btnVerRUsuarios.Size = new System.Drawing.Size(122, 27);
            this.btnVerRUsuarios.TabIndex = 14;
            this.btnVerRUsuarios.Text = "Ver registros";
            this.btnVerRUsuarios.UseVisualStyleBackColor = false;
            this.btnVerRUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(403, 548);
            this.Controls.Add(this.btnVerRUsuarios);
            this.Controls.Add(this.btnAceptarRUsuario);
            this.Controls.Add(this.btnVolverRUsuario);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRM_RegistroUsuario";
            this.Text = "FRM_RegistroUsuario";
            this.Load += new System.EventHandler(this.FRM_RegistroUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnVolverRUsuario;
        private System.Windows.Forms.Button btnAceptarRUsuario;
        private System.Windows.Forms.Button btnVerRUsuarios;
        private System.Windows.Forms.PictureBox hashicon;
    }
}