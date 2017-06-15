namespace __TheLibrary.WinUI
{
    partial class KiralananKitaplar
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
            this.VerilenKitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerilisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VerilenKitap,
            this.VerilisTarihi,
            this.ExpireDate,
            this.DateOfReturn,
            this.UyeAdi,
            this.PersonelAdi});
            this.dataGridView1.Location = new System.Drawing.Point(123, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 438);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // VerilenKitap
            // 
            this.VerilenKitap.DataPropertyName = "bookName";
            this.VerilenKitap.HeaderText = "Verilen Kitap Adı";
            this.VerilenKitap.Name = "VerilenKitap";
            // 
            // VerilisTarihi
            // 
            this.VerilisTarihi.DataPropertyName = "DateOfBorrow";
            this.VerilisTarihi.HeaderText = "Veriliş Tarihi";
            this.VerilisTarihi.Name = "VerilisTarihi";
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "Teslim Edilmesi Gereken Tarihi";
            this.ExpireDate.Name = "ExpireDate";
            // 
            // DateOfReturn
            // 
            this.DateOfReturn.DataPropertyName = "DateOfReturn";
            this.DateOfReturn.HeaderText = "Teslim Alınan Tarih";
            this.DateOfReturn.Name = "DateOfReturn";
            // 
            // UyeAdi
            // 
            this.UyeAdi.DataPropertyName = "memberFullName";
            this.UyeAdi.HeaderText = "Kitabı Alan Üye";
            this.UyeAdi.Name = "UyeAdi";
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.DataPropertyName = "employeeFullName";
            this.PersonelAdi.HeaderText = "Kitabı Veren Personel";
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // KiralananKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(955, 492);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KiralananKitaplar";
            this.Text = "KiralananKitaplar";
            this.Load += new System.EventHandler(this.KiralananKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerilenKitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerilisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
    }
}