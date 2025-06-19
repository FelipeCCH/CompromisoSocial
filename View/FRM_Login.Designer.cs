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
            this.correoElectronico = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // correoElectronico
            // 
            this.correoElectronico.AutoSize = true;
            this.correoElectronico.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoElectronico.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.correoElectronico.Location = new System.Drawing.Point(50, 141);
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.Size = new System.Drawing.Size(153, 17);
            this.correoElectronico.TabIndex = 0;
            this.correoElectronico.Text = "Correo eléctronico";
            this.correoElectronico.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ingresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Controls.Add(this.correoElectronico);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(59, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 417);
            this.panel1.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.contraseña.Location = new System.Drawing.Point(50, 253);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(96, 17);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Contraseña";
            this.contraseña.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(53, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 36);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(53, 273);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 36);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesión";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.CadetBlue;
            this.ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingresar.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ingresar.Location = new System.Drawing.Point(53, 344);
            this.ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(248, 33);
            this.ingresar.TabIndex = 14;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(469, 515);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Login";
            this.Text = "FRM_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label correoElectronico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingresar;
    }
}