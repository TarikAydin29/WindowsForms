namespace PasswordGenerator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunluğu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.chkSayi = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunluğu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.nudSifreUzunluğu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkOzelKarakter);
            this.groupBox1.Controls.Add(this.chkSayi);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Location = new System.Drawing.Point(18, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(466, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(14, 386);
            this.btnUret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(148, 70);
            this.btnUret.TabIndex = 3;
            this.btnUret.Text = "Şifre Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click_1);
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(198, 309);
            this.nudSifreSayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(180, 30);
            this.nudSifreSayisi.TabIndex = 2;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreUzunluğu
            // 
            this.nudSifreUzunluğu.Location = new System.Drawing.Point(198, 248);
            this.nudSifreUzunluğu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSifreUzunluğu.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSifreUzunluğu.Name = "nudSifreUzunluğu";
            this.nudSifreUzunluğu.Size = new System.Drawing.Size(180, 30);
            this.nudSifreUzunluğu.TabIndex = 2;
            this.nudSifreUzunluğu.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre Uzunluğu :";
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(14, 175);
            this.chkOzelKarakter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(154, 29);
            this.chkOzelKarakter.TabIndex = 0;
            this.chkOzelKarakter.Text = "Özel Karakter";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // chkSayi
            // 
            this.chkSayi.AutoSize = true;
            this.chkSayi.Location = new System.Drawing.Point(14, 134);
            this.chkSayi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSayi.Name = "chkSayi";
            this.chkSayi.Size = new System.Drawing.Size(73, 29);
            this.chkSayi.TabIndex = 0;
            this.chkSayi.Text = "Sayı";
            this.chkSayi.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(14, 94);
            this.chkKucukHarf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(131, 29);
            this.chkKucukHarf.TabIndex = 0;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(14, 53);
            this.chkBuyukHarf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(130, 29);
            this.chkBuyukHarf.TabIndex = 0;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // txtSifreler
            // 
            this.txtSifreler.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSifreler.Location = new System.Drawing.Point(492, 0);
            this.txtSifreler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.Size = new System.Drawing.Size(604, 531);
            this.txtSifreler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 531);
            this.Controls.Add(this.txtSifreler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunluğu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunluğu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.CheckBox chkSayi;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.TextBox txtSifreler;
    }
}

