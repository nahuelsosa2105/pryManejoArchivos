namespace pryManejoArchivos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCargarLindo = new System.Windows.Forms.Button();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.btnCargar3 = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnCargarLindo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(13, 13);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(199, 56);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar archivo de BD - lvl1";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(233, 13);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "-";
            // 
            // btnCargarLindo
            // 
            this.btnCargarLindo.Location = new System.Drawing.Point(16, 75);
            this.btnCargarLindo.Name = "btnCargarLindo";
            this.btnCargarLindo.Size = new System.Drawing.Size(199, 56);
            this.btnCargarLindo.TabIndex = 2;
            this.btnCargarLindo.Text = "Cargar archivo de BD - lvl2";
            this.btnCargarLindo.UseVisualStyleBackColor = true;
            this.btnCargarLindo.Click += new System.EventHandler(this.btnCargarLindo_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.Location = new System.Drawing.Point(233, 75);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(555, 331);
            this.lblResultado2.TabIndex = 3;
            this.lblResultado2.Text = "-";
            // 
            // btnCargar3
            // 
            this.btnCargar3.Location = new System.Drawing.Point(16, 137);
            this.btnCargar3.Name = "btnCargar3";
            this.btnCargar3.Size = new System.Drawing.Size(199, 56);
            this.btnCargar3.TabIndex = 4;
            this.btnCargar3.Text = "Cargar archivo de BD - lvl3";
            this.btnCargar3.UseVisualStyleBackColor = true;
            this.btnCargar3.Click += new System.EventHandler(this.btnCargar3_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(16, 275);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(772, 201);
            this.grilla.TabIndex = 5;
            // 
            // btnCargarLindo2
            // 
            this.btnCargarLindo2.Location = new System.Drawing.Point(16, 199);
            this.btnCargarLindo2.Name = "btnCargarLindo2";
            this.btnCargarLindo2.Size = new System.Drawing.Size(199, 56);
            this.btnCargarLindo2.TabIndex = 6;
            this.btnCargarLindo2.Text = "Cargar archivo de BD - lvl4";
            this.btnCargarLindo2.UseVisualStyleBackColor = true;
            this.btnCargarLindo2.Click += new System.EventHandler(this.btnCargarLindo2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnCargarLindo2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnCargar3);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.btnCargarLindo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmPrincipal";
            this.Text = "Manejo de Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCargarLindo;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button btnCargar3;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnCargarLindo2;
    }
}

