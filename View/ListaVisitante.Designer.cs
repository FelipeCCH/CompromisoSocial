namespace CompromisoSocial.View
{
    partial class ListaVisitante
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
            this.datagridListaVisitante = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrarVisita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridListaVisitante
            // 
            this.datagridListaVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagridListaVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridListaVisitante.EnableHeadersVisualStyles = false;
            this.datagridListaVisitante.Location = new System.Drawing.Point(60, 95);
            this.datagridListaVisitante.Name = "datagridListaVisitante";
            this.datagridListaVisitante.RowHeadersWidth = 51;
            this.datagridListaVisitante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridListaVisitante.Size = new System.Drawing.Size(680, 260);
            this.datagridListaVisitante.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(449, 381);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 36);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.lblTitulo.Location = new System.Drawing.Point(-2, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 40);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Listado de Visitas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarVisita
            // 
            this.btnRegistrarVisita.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVisita.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnRegistrarVisita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarVisita.Location = new System.Drawing.Point(198, 381);
            this.btnRegistrarVisita.Name = "btnRegistrarVisita";
            this.btnRegistrarVisita.Size = new System.Drawing.Size(178, 36);
            this.btnRegistrarVisita.TabIndex = 8;
            this.btnRegistrarVisita.Text = "Registrar Visita";
            this.btnRegistrarVisita.UseVisualStyleBackColor = false;
            // 
            // ListaVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarVisita);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.datagridListaVisitante);
            this.Name = "ListaVisitante";
            this.Text = "ListaVisitante";
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaVisitante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridListaVisitante;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarVisita;
    }
}