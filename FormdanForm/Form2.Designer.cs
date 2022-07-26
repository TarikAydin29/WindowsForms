namespace FormdanForm
{
    partial class Form2
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
            this.cmbxRenkler = new System.Windows.Forms.ComboBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxRenkler
            // 
            this.cmbxRenkler.FormattingEnabled = true;
            this.cmbxRenkler.Items.AddRange(new object[] {
            "Kırmızı",
            "Siyah",
            "Mavi",
            "Yeşil"});
            this.cmbxRenkler.Location = new System.Drawing.Point(12, 12);
            this.cmbxRenkler.Name = "cmbxRenkler";
            this.cmbxRenkler.Size = new System.Drawing.Size(334, 24);
            this.cmbxRenkler.TabIndex = 0;
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(47, 59);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(111, 41);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(197, 59);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(111, 41);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 119);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cmbxRenkler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxRenkler;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
    }
}