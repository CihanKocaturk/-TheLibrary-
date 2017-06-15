namespace __TheLibrary.WinUI
{
    partial class KitapKiralama
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
            this.cmbVerilenKitap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Verilen Kitap:";
            // 
            // cmbVerilenKitap
            // 
            this.cmbVerilenKitap.FormattingEnabled = true;
            this.cmbVerilenKitap.Location = new System.Drawing.Point(106, 36);
            this.cmbVerilenKitap.Name = "cmbVerilenKitap";
            this.cmbVerilenKitap.Size = new System.Drawing.Size(204, 21);
            this.cmbVerilenKitap.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teslim Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Üye Adı:";
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(106, 118);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(204, 21);
            this.cmbMembers.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çalışan Adı:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(106, 160);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(204, 21);
            this.cmbEmployees.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(225, 207);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.Location = new System.Drawing.Point(110, 78);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpireDate.TabIndex = 1;
            // 
            // KitapKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(424, 384);
            this.Controls.Add(this.dtpExpireDate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVerilenKitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KitapKiralama";
            this.Text = "Kitap Kiralama Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVerilenKitap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
    }
}