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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboRol);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbClave);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.lbCorreo);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(52, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 527);
            this.panel1.TabIndex = 0;
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboRol.Items.AddRange(new object[] {
            "Director",
            "Administrador Principal",
            "Administrador Secundario"});
            this.cboRol.Location = new System.Drawing.Point(75, 433);
            this.cboRol.Margin = new System.Windows.Forms.Padding(4);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(269, 24);
            this.cboRol.TabIndex = 1;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitulo.Location = new System.Drawing.Point(53, 45);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(316, 31);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Registrar Nuevo Usuario";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbClave.Location = new System.Drawing.Point(75, 330);
            this.lbClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(184, 24);
            this.lbClave.TabIndex = 9;
            this.lbClave.Text = "Digire su contraseña";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTelefono.Location = new System.Drawing.Point(75, 260);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(86, 24);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRol.Location = new System.Drawing.Point(75, 406);
            this.lbRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(131, 24);
            this.lbRol.TabIndex = 6;
            this.lbRol.Text = "Selecionar Rol";
            this.lbRol.Click += new System.EventHandler(this.lbRol_Click);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbCorreo.Location = new System.Drawing.Point(69, 183);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(67, 24);
            this.lbCorreo.TabIndex = 5;
            this.lbCorreo.Text = "Correo";
            this.lbCorreo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNombre.Location = new System.Drawing.Point(69, 105);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(80, 24);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Location = new System.Drawing.Point(75, 210);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(269, 31);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtClave.Location = new System.Drawing.Point(75, 357);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(269, 31);
            this.txtClave.TabIndex = 2;
            this.txtClave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTelefono.Location = new System.Drawing.Point(75, 287);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(269, 31);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Nombre.Location = new System.Drawing.Point(75, 132);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Multiline = true;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(269, 31);
            this.Nombre.TabIndex = 0;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(52, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVolver);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.Green;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aceptar.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptar.Location = new System.Drawing.Point(168, 599);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(101, 33);
            this.Aceptar.TabIndex = 13;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.btnAceptar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(336, 599);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ver registros";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(537, 675);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_RegistroUsuario";
            this.Text = "FRM_RegistroUsuario";
            this.Load += new System.EventHandler(this.FRM_RegistroUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button3;
    }
}