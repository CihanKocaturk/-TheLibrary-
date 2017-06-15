namespace __TheLibrary.WinUI
{
    partial class KitapKayıt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtISBNNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cmbKitapYazari = new System.Windows.Forms.ComboBox();
            this.cmbRafNo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Raf Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Basım Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ISBN Numarası:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(125, 47);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // txtISBNNo
            // 
            this.txtISBNNo.Location = new System.Drawing.Point(125, 145);
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.Size = new System.Drawing.Size(200, 20);
            this.txtISBNNo.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(213, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kitap Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(125, 113);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBasimTarihi.TabIndex = 2;
            // 
            // cmbYayinEvi
            // 
            this.cmbYayinEvi.FormattingEnabled = true;
            this.cmbYayinEvi.Items.AddRange(new object[] {
            "Jules verne"});
            this.cmbYayinEvi.Location = new System.Drawing.Point(125, 254);
            this.cmbYayinEvi.Name = "cmbYayinEvi";
            this.cmbYayinEvi.Size = new System.Drawing.Size(200, 21);
            this.cmbYayinEvi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Yayın Evi:";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Jules verne"});
            this.cmbTur.Location = new System.Drawing.Point(125, 181);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 21);
            this.cmbTur.TabIndex = 4;
            // 
            // cmbKitapYazari
            // 
            this.cmbKitapYazari.FormattingEnabled = true;
            this.cmbKitapYazari.Items.AddRange(new object[] {
            "Jules verne"});
            this.cmbKitapYazari.Location = new System.Drawing.Point(125, 76);
            this.cmbKitapYazari.Name = "cmbKitapYazari";
            this.cmbKitapYazari.Size = new System.Drawing.Size(200, 21);
            this.cmbKitapYazari.TabIndex = 1;
            // 
            // cmbRafNo
            // 
            this.cmbRafNo.FormattingEnabled = true;
            this.cmbRafNo.Items.AddRange(new object[] {
            "Jules verne"});
            this.cmbRafNo.Location = new System.Drawing.Point(125, 218);
            this.cmbRafNo.Name = "cmbRafNo";
            this.cmbRafNo.Size = new System.Drawing.Size(200, 21);
            this.cmbRafNo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KitapAdi,
            this.YazarAdi,
            this.YazarSoyadi,
            this.BasimTarihi,
            this.ISBNNo,
            this.Turu,
            this.RafNo,
            this.YayinEvi});
            this.dataGridView1.Location = new System.Drawing.Point(362, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 283);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "Name";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // YazarAdi
            // 
            this.YazarAdi.DataPropertyName = "authorFirstName";
            this.YazarAdi.HeaderText = "Yazar Adı";
            this.YazarAdi.Name = "YazarAdi";
            // 
            // YazarSoyadi
            // 
            this.YazarSoyadi.DataPropertyName = "authorLastName";
            this.YazarSoyadi.HeaderText = "Yazar Soyadı";
            this.YazarSoyadi.Name = "YazarSoyadi";
            // 
            // BasimTarihi
            // 
            this.BasimTarihi.DataPropertyName = "DateOfPublish";
            this.BasimTarihi.HeaderText = "Basım Tarihi";
            this.BasimTarihi.Name = "BasimTarihi";
            // 
            // ISBNNo
            // 
            this.ISBNNo.DataPropertyName = "ISBNNo";
            this.ISBNNo.HeaderText = "ISBN No.";
            this.ISBNNo.Name = "ISBNNo";
            // 
            // Turu
            // 
            this.Turu.DataPropertyName = "categoryName";
            this.Turu.HeaderText = "Türü";
            this.Turu.Name = "Turu";
            // 
            // RafNo
            // 
            this.RafNo.DataPropertyName = "shelfNo";
            this.RafNo.HeaderText = "Raf No.";
            this.RafNo.Name = "RafNo";
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "publisherName";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.Name = "YayinEvi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(97, 307);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(156, 356);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // KitapKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1190, 429);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbKitapYazari);
            this.Controls.Add(this.cmbRafNo);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.cmbYayinEvi);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtISBNNo);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KitapKayıt";
            this.Text = "Yeni Kitap Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtISBNNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.ComboBox cmbYayinEvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.ComboBox cmbKitapYazari;
        private System.Windows.Forms.ComboBox cmbRafNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
    }
}

