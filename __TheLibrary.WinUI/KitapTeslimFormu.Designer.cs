namespace __TheLibrary.WinUI
{
    partial class KitapTeslimFormu
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
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsbnNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiraTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalisanAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-185, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = " ISBN no :";
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(277, 45);
            this.btnTeslimAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(108, 21);
            this.btnTeslimAl.TabIndex = 1;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " ISBN no :";
            // 
            // txtIsbnNo
            // 
            this.txtIsbnNo.Location = new System.Drawing.Point(97, 45);
            this.txtIsbnNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbnNo.Name = "txtIsbnNo";
            this.txtIsbnNo.Size = new System.Drawing.Size(125, 20);
            this.txtIsbnNo.TabIndex = 0;
            this.txtIsbnNo.TextChanged += new System.EventHandler(this.txtIsbnNo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAd,
            this.UyeID,
            this.ISBNno,
            this.KiraTarihi,
            this.TeslimTarihi,
            this.CalisanAdSoyad});
            this.dataGridView1.Location = new System.Drawing.Point(24, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // KitapAd
            // 
            this.KitapAd.DataPropertyName = "bookName";
            this.KitapAd.HeaderText = "Kitap Adi";
            this.KitapAd.Name = "KitapAd";
            this.KitapAd.ReadOnly = true;
            this.KitapAd.Width = 120;
            // 
            // UyeID
            // 
            this.UyeID.DataPropertyName = "memberFullName";
            this.UyeID.HeaderText = "Uye Adı";
            this.UyeID.Name = "UyeID";
            this.UyeID.ReadOnly = true;
            this.UyeID.Width = 120;
            // 
            // ISBNno
            // 
            this.ISBNno.DataPropertyName = "bookISBNNO";
            this.ISBNno.HeaderText = "ISBNno";
            this.ISBNno.Name = "ISBNno";
            this.ISBNno.ReadOnly = true;
            // 
            // KiraTarihi
            // 
            this.KiraTarihi.DataPropertyName = "DateOfBorrow";
            this.KiraTarihi.HeaderText = "KiraTarihi";
            this.KiraTarihi.Name = "KiraTarihi";
            this.KiraTarihi.ReadOnly = true;
            this.KiraTarihi.Width = 200;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.DataPropertyName = "ExpireDate";
            this.TeslimTarihi.HeaderText = "TeslimTarihi";
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.ReadOnly = true;
            this.TeslimTarihi.Width = 200;
            // 
            // CalisanAdSoyad
            // 
            this.CalisanAdSoyad.DataPropertyName = "employeeFullName";
            this.CalisanAdSoyad.HeaderText = "Görevli Adi";
            this.CalisanAdSoyad.Name = "CalisanAdSoyad";
            this.CalisanAdSoyad.ReadOnly = true;
            this.CalisanAdSoyad.Width = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Teslim Alınacak Kitabı Seçiniz : ";
            // 
            // KitapTeslimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1088, 386);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsbnNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "KitapTeslimFormu";
            this.Text = "KitapTeslimFormu";
            this.Load += new System.EventHandler(this.KitapTeslimFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsbnNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNno;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiraTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalisanAdSoyad;
    }
}