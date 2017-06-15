namespace __TheLibrary.WinUI
{
    partial class Kitap_Listesi
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 380);
            this.dataGridView1.TabIndex = 7;
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
            // Kitap_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(864, 417);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kitap_Listesi";
            this.Text = "Kitap_Listesi";
            this.Load += new System.EventHandler(this.Kitap_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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