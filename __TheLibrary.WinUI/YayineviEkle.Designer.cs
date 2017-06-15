namespace __TheLibrary.WinUI
{
    partial class YayineviEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYayineviAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yayınevi Adı:";
            // 
            // txtYayineviAdi
            // 
            this.txtYayineviAdi.Location = new System.Drawing.Point(133, 44);
            this.txtYayineviAdi.Name = "txtYayineviAdi";
            this.txtYayineviAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYayineviAdi.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(158, 88);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 199);
            this.listBox1.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(52, 88);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // YayineviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(296, 366);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtYayineviAdi);
            this.Controls.Add(this.label1);
            this.Name = "YayineviEkle";
            this.Text = "YayineviEkle";
            this.Load += new System.EventHandler(this.YayineviEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYayineviAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSil;
    }
}