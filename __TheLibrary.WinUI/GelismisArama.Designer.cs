namespace __TheLibrary.WinUI
{
    partial class GelismisArama
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
            this.lblTur = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRaf = new System.Windows.Forms.ComboBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYayinevi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
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
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBNNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbTur = new System.Windows.Forms.CheckBox();
            this.chbRaf = new System.Windows.Forms.CheckBox();
            this.chbYazar = new System.Windows.Forms.CheckBox();
            this.chbYayinevi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(332, 41);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(104, 13);
            this.lblTur.TabIndex = 17;
            this.lblTur.Text = "Lütfen bir tür seçiniz.";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(335, 79);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lütfen bir raf seçiniz.";
            // 
            // cmbRaf
            // 
            this.cmbRaf.FormattingEnabled = true;
            this.cmbRaf.Location = new System.Drawing.Point(523, 79);
            this.cmbRaf.Name = "cmbRaf";
            this.cmbRaf.Size = new System.Drawing.Size(121, 21);
            this.cmbRaf.TabIndex = 12;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(691, 79);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(121, 21);
            this.cmbYazar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lütfen bir yazar seçiniz.";
            // 
            // cmbYayinevi
            // 
            this.cmbYayinevi.FormattingEnabled = true;
            this.cmbYayinevi.Location = new System.Drawing.Point(887, 79);
            this.cmbYayinevi.Name = "cmbYayinevi";
            this.cmbYayinevi.Size = new System.Drawing.Size(121, 21);
            this.cmbYayinevi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lütfen bir yayınevi seçiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kitap adına göre...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yazar adına göre...";
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(34, 222);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(100, 20);
            this.txtKitap.TabIndex = 6;
            this.txtKitap.TextChanged += new System.EventHandler(this.txtKitap_TextChanged);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(34, 308);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 8;
            this.txtYazar.TextChanged += new System.EventHandler(this.txtYazar_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(190, 184);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(842, 321);
            this.dataGridView1.TabIndex = 16;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
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
            this.Turu.DataPropertyName = "CategoryName";
            this.Turu.HeaderText = "Türü";
            this.Turu.Name = "Turu";
            // 
            // RafNo
            // 
            this.RafNo.DataPropertyName = "ShelfNo";
            this.RafNo.HeaderText = "Raf No.";
            this.RafNo.Name = "RafNo";
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "PublisherName";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.Name = "YayinEvi";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(31, 355);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(122, 13);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN numarasına göre...";
            // 
            // txtISBNNo
            // 
            this.txtISBNNo.Location = new System.Drawing.Point(34, 399);
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.Size = new System.Drawing.Size(100, 20);
            this.txtISBNNo.TabIndex = 10;
            this.txtISBNNo.TextChanged += new System.EventHandler(this.txtISBNNo_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(933, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lütfen arama yapmak istediğiniz kriterleri seçiniz.";
            // 
            // chbTur
            // 
            this.chbTur.AutoSize = true;
            this.chbTur.Location = new System.Drawing.Point(34, 70);
            this.chbTur.Name = "chbTur";
            this.chbTur.Size = new System.Drawing.Size(42, 17);
            this.chbTur.TabIndex = 1;
            this.chbTur.Text = "Tür";
            this.chbTur.UseVisualStyleBackColor = true;
            this.chbTur.CheckedChanged += new System.EventHandler(this.chbTur_CheckedChanged);
            // 
            // chbRaf
            // 
            this.chbRaf.AutoSize = true;
            this.chbRaf.Location = new System.Drawing.Point(34, 93);
            this.chbRaf.Name = "chbRaf";
            this.chbRaf.Size = new System.Drawing.Size(43, 17);
            this.chbRaf.TabIndex = 2;
            this.chbRaf.Text = "Raf";
            this.chbRaf.UseVisualStyleBackColor = true;
            this.chbRaf.CheckedChanged += new System.EventHandler(this.chbRaf_CheckedChanged);
            // 
            // chbYazar
            // 
            this.chbYazar.AutoSize = true;
            this.chbYazar.Location = new System.Drawing.Point(34, 116);
            this.chbYazar.Name = "chbYazar";
            this.chbYazar.Size = new System.Drawing.Size(53, 17);
            this.chbYazar.TabIndex = 3;
            this.chbYazar.Text = "Yazar";
            this.chbYazar.UseVisualStyleBackColor = true;
            this.chbYazar.CheckedChanged += new System.EventHandler(this.chbYazar_CheckedChanged);
            // 
            // chbYayinevi
            // 
            this.chbYayinevi.AutoSize = true;
            this.chbYayinevi.Location = new System.Drawing.Point(34, 139);
            this.chbYayinevi.Name = "chbYayinevi";
            this.chbYayinevi.Size = new System.Drawing.Size(66, 17);
            this.chbYayinevi.TabIndex = 4;
            this.chbYayinevi.Text = "Yayınevi";
            this.chbYayinevi.UseVisualStyleBackColor = true;
            this.chbYayinevi.CheckedChanged += new System.EventHandler(this.chbYayinevi_CheckedChanged);
            // 
            // GelismisArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1065, 517);
            this.Controls.Add(this.chbYayinevi);
            this.Controls.Add(this.chbYazar);
            this.Controls.Add(this.chbRaf);
            this.Controls.Add(this.chbTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtISBNNo);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYayinevi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.cmbRaf);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.lblTur);
            this.Name = "GelismisArama";
            this.Text = "GelismisArama";
            this.Load += new System.EventHandler(this.GelismisArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRaf;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYayinevi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitap;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBNNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbTur;
        private System.Windows.Forms.CheckBox chbRaf;
        private System.Windows.Forms.CheckBox chbYazar;
        private System.Windows.Forms.CheckBox chbYayinevi;
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