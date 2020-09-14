namespace HerramientasAmbienteColaborativas
{
    partial class Form3
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
            this.btnConductor = new System.Windows.Forms.Button();
            this.lblConductor = new System.Windows.Forms.Label();
            this.btnPlaca = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dgvAutomoviles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMostrar = new System.Windows.Forms.ComboBox();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConductor
            // 
            this.btnConductor.Location = new System.Drawing.Point(370, 92);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(75, 23);
            this.btnConductor.TabIndex = 24;
            this.btnConductor.Text = "Mostrar";
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(343, 55);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(59, 13);
            this.lblConductor.TabIndex = 22;
            this.lblConductor.Text = "Conductor:";
            // 
            // btnPlaca
            // 
            this.btnPlaca.Location = new System.Drawing.Point(370, 92);
            this.btnPlaca.Name = "btnPlaca";
            this.btnPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnPlaca.TabIndex = 21;
            this.btnPlaca.Text = "Mostrar";
            this.btnPlaca.UseVisualStyleBackColor = true;
            this.btnPlaca.Click += new System.EventHandler(this.btnPlaca_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(343, 55);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 19;
            this.lblPlaca.Text = "Placa:";
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(370, 92);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(75, 23);
            this.btnMarca.TabIndex = 18;
            this.btnMarca.Text = "Mostrar";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(414, 55);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 17;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(343, 55);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca:";
            // 
            // dgvAutomoviles
            // 
            this.dgvAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomoviles.Location = new System.Drawing.Point(84, 121);
            this.dgvAutomoviles.Name = "dgvAutomoviles";
            this.dgvAutomoviles.Size = new System.Drawing.Size(637, 171);
            this.dgvAutomoviles.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mostrar:";
            // 
            // cmbMostrar
            // 
            this.cmbMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMostrar.FormattingEnabled = true;
            this.cmbMostrar.Items.AddRange(new object[] {
            "Todos los automoviles",
            "Segun marca",
            "Segun placa",
            "Segun dueño"});
            this.cmbMostrar.Location = new System.Drawing.Point(130, 50);
            this.cmbMostrar.Name = "cmbMostrar";
            this.cmbMostrar.Size = new System.Drawing.Size(121, 21);
            this.cmbMostrar.TabIndex = 13;
            this.cmbMostrar.SelectedIndexChanged += new System.EventHandler(this.cmbMostrar_SelectedIndexChanged);
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(414, 55);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(100, 20);
            this.txtConductor.TabIndex = 23;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(414, 55);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConductor);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.btnPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvAutomoviles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMostrar);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Button btnPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.DataGridView dgvAutomoviles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMostrar;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}