namespace CompromisoSocial.View
{
    partial class FRM_RegistroVisita
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
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptarVisita = new System.Windows.Forms.Button();
            this.btnVerVisitas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtFechaSalida);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbClave);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.lbCorreo);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(39, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 429);
            this.panel1.TabIndex = 0;
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaSalida.Location = new System.Drawing.Point(56, 353);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.ShowUpDown = true;
            this.dtFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtFechaSalida.TabIndex = 12;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitulo.Location = new System.Drawing.Point(40, 37);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(227, 25);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Registrar Nueva Visita";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbClave.Location = new System.Drawing.Point(56, 268);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(55, 19);
            this.lbClave.TabIndex = 9;
            this.lbClave.Text = "Asunto";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTelefono.Location = new System.Drawing.Point(56, 211);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(59, 19);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Destino";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRol.Location = new System.Drawing.Point(56, 330);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(92, 19);
            this.lbRol.TabIndex = 6;
            this.lbRol.Text = "Fecha Salida";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbCorreo.Location = new System.Drawing.Point(52, 149);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(65, 19);
            this.lbCorreo.TabIndex = 5;
            this.lbCorreo.Text = "Nombre";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNombre.Location = new System.Drawing.Point(52, 85);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 19);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(56, 171);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(56, 290);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(203, 29);
            this.txtAsunto.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(56, 233);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(203, 26);
            this.txtDestino.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(56, 107);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(203, 26);
            this.txtCedula.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(289, 487);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 27);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolverRUsuario_Click);
            // 
            // btnAceptarVisita
            // 
            this.btnAceptarVisita.BackColor = System.Drawing.Color.Green;
            this.btnAceptarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarVisita.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarVisita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptarVisita.Location = new System.Drawing.Point(39, 487);
            this.btnAceptarVisita.Name = "btnAceptarVisita";
            this.btnAceptarVisita.Size = new System.Drawing.Size(88, 27);
            this.btnAceptarVisita.TabIndex = 13;
            this.btnAceptarVisita.Text = "Aceptar";
            this.btnAceptarVisita.UseVisualStyleBackColor = false;
            this.btnAceptarVisita.Click += new System.EventHandler(this.btnAceptar);
            // 
            // btnVerVisitas
            // 
            this.btnVerVisitas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerVisitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerVisitas.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVisitas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerVisitas.Location = new System.Drawing.Point(145, 487);
            this.btnVerVisitas.Name = "btnVerVisitas";
            this.btnVerVisitas.Size = new System.Drawing.Size(122, 27);
            this.btnVerVisitas.TabIndex = 14;
            this.btnVerVisitas.Text = "Ver registros";
            this.btnVerVisitas.UseVisualStyleBackColor = false;
            this.btnVerVisitas.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_RegistroVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(403, 548);
            this.Controls.Add(this.btnVerVisitas);
            this.Controls.Add(this.btnAceptarVisita);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRM_RegistroVisita";
            this.Text = "FRM_RegistroUsuario";
            this.Load += new System.EventHandler(this.FRM_RegistroUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptarVisita;
        private System.Windows.Forms.Button btnVerVisitas;
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.Label lbRol;
    }
}