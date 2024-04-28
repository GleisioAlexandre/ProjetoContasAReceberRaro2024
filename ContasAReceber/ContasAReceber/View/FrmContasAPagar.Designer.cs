namespace ContasAReceber.View
{
    partial class FrmContasAPagar
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
            this.dtgContasAPagar = new System.Windows.Forms.DataGridView();
            this.gpbTitulos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).BeginInit();
            this.gpbTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgContasAPagar
            // 
            this.dtgContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContasAPagar.Location = new System.Drawing.Point(-1, 206);
            this.dtgContasAPagar.Name = "dtgContasAPagar";
            this.dtgContasAPagar.Size = new System.Drawing.Size(1235, 376);
            this.dtgContasAPagar.TabIndex = 0;
            // 
            // gpbTitulos
            // 
            this.gpbTitulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTitulos.Controls.Add(this.comboBox1);
            this.gpbTitulos.Controls.Add(this.label1);
            this.gpbTitulos.Location = new System.Drawing.Point(-1, 12);
            this.gpbTitulos.Name = "gpbTitulos";
            this.gpbTitulos.Size = new System.Drawing.Size(1235, 188);
            this.gpbTitulos.TabIndex = 1;
            this.gpbTitulos.TabStop = false;
            this.gpbTitulos.Text = "Titulos a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor *";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gleisio Varela Alexandre",
            "Adão Alexandre"});
            this.comboBox1.Location = new System.Drawing.Point(16, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FrmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 632);
            this.Controls.Add(this.gpbTitulos);
            this.Controls.Add(this.dtgContasAPagar);
            this.MaximizeBox = false;
            this.Name = "FrmContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContasAPagar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAPagar)).EndInit();
            this.gpbTitulos.ResumeLayout(false);
            this.gpbTitulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgContasAPagar;
        private System.Windows.Forms.GroupBox gpbTitulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}