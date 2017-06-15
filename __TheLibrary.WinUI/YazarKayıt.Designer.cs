namespace __TheLibrary.WinUI
{
    partial class YazarKayıt
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
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lvYazar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(113, 65);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(135, 20);
            this.txtYazarAdi.TabIndex = 0;
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(113, 107);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(135, 20);
            this.txtYazarSoyadi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yazar Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(56, 159);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 36);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(117, 159);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(65, 36);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(198, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 36);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lvYazar
            // 
            this.lvYazar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvYazar.FullRowSelect = true;
            this.lvYazar.GridLines = true;
            this.lvYazar.Location = new System.Drawing.Point(291, 21);
            this.lvYazar.MultiSelect = false;
            this.lvYazar.Name = "lvYazar";
            this.lvYazar.Size = new System.Drawing.Size(265, 269);
            this.lvYazar.TabIndex = 5;
            this.lvYazar.UseCompatibleStateImageBehavior = false;
            this.lvYazar.View = System.Windows.Forms.View.Details;
            this.lvYazar.DoubleClick += new System.EventHandler(this.lvYazar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yazar Adı";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazar Soyadı";
            this.columnHeader2.Width = 130;
            // 
            // YazarKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(602, 337);
            this.Controls.Add(this.lvYazar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.txtYazarAdi);
            this.Name = "YazarKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazarKayıt";
            this.Load += new System.EventHandler(this.YazarKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lvYazar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}