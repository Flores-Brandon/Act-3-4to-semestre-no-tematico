namespace Act_3_4to_semestre
{
    partial class Form1
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
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnXJ = new System.Windows.Forms.Button();
            this.btnNoEstructurados = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(0, 0);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 0;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnXJ
            // 
            this.btnXJ.Location = new System.Drawing.Point(0, 29);
            this.btnXJ.Name = "btnXJ";
            this.btnXJ.Size = new System.Drawing.Size(92, 23);
            this.btnXJ.TabIndex = 1;
            this.btnXJ.Text = "XML /JSON.";
            this.btnXJ.UseVisualStyleBackColor = true;
            this.btnXJ.Click += new System.EventHandler(this.btnXJ_Click);
            // 
            // btnNoEstructurados
            // 
            this.btnNoEstructurados.Location = new System.Drawing.Point(0, 58);
            this.btnNoEstructurados.Name = "btnNoEstructurados";
            this.btnNoEstructurados.Size = new System.Drawing.Size(92, 37);
            this.btnNoEstructurados.TabIndex = 2;
            this.btnNoEstructurados.Text = "No Estructurados";
            this.btnNoEstructurados.UseVisualStyleBackColor = true;
            this.btnNoEstructurados.Click += new System.EventHandler(this.btnNoEstructurados_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(227, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(442, 362);
            this.dataGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnNoEstructurados);
            this.Controls.Add(this.btnXJ);
            this.Controls.Add(this.btnCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnXJ;
        private System.Windows.Forms.Button btnNoEstructurados;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

