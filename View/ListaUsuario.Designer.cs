namespace CompromisoSocial.View
{
    partial class ListaUsuario
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOtro = new System.Windows.Forms.Button();
            this.datagridListaUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(110, 370);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Location = new System.Drawing.Point(0, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 40);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Usuarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOtro
            // 
            this.btnOtro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOtro.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOtro.ForeColor = System.Drawing.Color.White;
            this.btnOtro.Location = new System.Drawing.Point(570, 370);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(120, 36);
            this.btnOtro.TabIndex = 3;
            this.btnOtro.Text = "Otro botón";
            this.btnOtro.UseVisualStyleBackColor = false;
            // 
            // datagridListaUsuario
            // 
            this.datagridListaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagridListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridListaUsuario.Location = new System.Drawing.Point(60, 80);
            this.datagridListaUsuario.Name = "datagridListaUsuario";
            this.datagridListaUsuario.Size = new System.Drawing.Size(680, 260);
            this.datagridListaUsuario.TabIndex = 4;
            this.datagridListaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridListaUsuario_CellContentClick_1);
            // 
            // ListaUsuario
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridListaUsuario);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Name = "ListaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.ListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaUsuario)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.DataGridView datagridListaUsuario;
    }
}
