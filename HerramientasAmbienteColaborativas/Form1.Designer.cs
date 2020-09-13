namespace HerramientasAmbienteColaborativas
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pbCaratula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(552, 339);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pbCaratula
            // 
            this.pbCaratula.Location = new System.Drawing.Point(37, 26);
            this.pbCaratula.Name = "pbCaratula";
            this.pbCaratula.Size = new System.Drawing.Size(590, 307);
            this.pbCaratula.TabIndex = 1;
            this.pbCaratula.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 374);
            this.Controls.Add(this.pbCaratula);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pbCaratula;
    }
}

