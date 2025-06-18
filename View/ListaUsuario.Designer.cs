namespace CompromisoSocial.View
{
    partial class ListaUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.datagridListaUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // datagridListaUsuario
            // 
            this.datagridListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridListaUsuario.Location = new System.Drawing.Point(12, 76);
            this.datagridListaUsuario.Name = "datagridListaUsuario";
            this.datagridListaUsuario.Size = new System.Drawing.Size(673, 222);
            this.datagridListaUsuario.TabIndex = 4;
            this.datagridListaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridListaUsuario_CellContentClick_1);
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridListaUsuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ListaUsuario";
            this.Text = "ListaUsuario";
            this.Load += new System.EventHandler(this.ListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datagridListaUsuario;
    }
}