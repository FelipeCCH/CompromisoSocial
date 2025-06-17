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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbClave);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.lbCorreo);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(170, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 429);
            this.panel1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(56, 107);
            this.Nombre.Multiline = true;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(249, 26);
            this.Nombre.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 171);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 26);
            this.textBox3.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(52, 85);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 19);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(52, 149);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(56, 19);
            this.lbCorreo.TabIndex = 5;
            this.lbCorreo.Text = "Correo";
            this.lbCorreo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.Location = new System.Drawing.Point(58, 320);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(31, 19);
            this.lbRol.TabIndex = 6;
            this.lbRol.Text = "Rol";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(56, 211);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(68, 19);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.Location = new System.Drawing.Point(56, 268);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(46, 19);
            this.lbClave.TabIndex = 9;
            this.lbClave.Text = "Clave";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(80, 29);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(188, 28);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Registro Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Visitante"});
            this.comboBox1.Location = new System.Drawing.Point(62, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FRM_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 514);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_RegistroUsuario";
            this.Text = "FRM_RegistroUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}