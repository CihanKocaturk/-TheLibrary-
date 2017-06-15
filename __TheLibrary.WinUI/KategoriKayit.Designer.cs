namespace __TheLibrary.WinUI
{
    partial class KategoriKayit
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
            this.lstTurler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTurAciklamasi = new System.Windows.Forms.TextBox();
            this.txtTurAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTurler
            // 
            this.lstTurler.FormattingEnabled = true;
            this.lstTurler.Location = new System.Drawing.Point(21, 174);
            this.lstTurler.Name = "lstTurler";
            this.lstTurler.Size = new System.Drawing.Size(212, 147);
            this.lstTurler.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(151, 121);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tür Açıklaması:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tür Adı:";
            // 
            // TxtTurAciklamasi
            // 
            this.TxtTurAciklamasi.Location = new System.Drawing.Point(126, 68);
            this.TxtTurAciklamasi.Name = "TxtTurAciklamasi";
            this.TxtTurAciklamasi.Size = new System.Drawing.Size(100, 20);
            this.TxtTurAciklamasi.TabIndex = 1;
            // 
            // txtTurAdi
            // 
            this.txtTurAdi.Location = new System.Drawing.Point(126, 26);
            this.txtTurAdi.Name = "txtTurAdi";
            this.txtTurAdi.Size = new System.Drawing.Size(100, 20);
            this.txtTurAdi.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(48, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // KategoriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 360);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstTurler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTurAciklamasi);
            this.Controls.Add(this.txtTurAdi);
            this.Name = "KategoriKayit";
            this.Text = "KategoriKayit";
            this.Load += new System.EventHandler(this.KategoriKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTurler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTurAciklamasi;
        private System.Windows.Forms.TextBox txtTurAdi;
        private System.Windows.Forms.Button btnSil;
    }
}