namespace __TheLibrary.WinUI
{
    partial class RafKayit
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
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRafTuru = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstRaf = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raf Numarası:";
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(125, 35);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(121, 20);
            this.txtRafNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raf Turu:";
            // 
            // cmbRafTuru
            // 
            this.cmbRafTuru.FormattingEnabled = true;
            this.cmbRafTuru.Location = new System.Drawing.Point(125, 80);
            this.cmbRafTuru.Name = "cmbRafTuru";
            this.cmbRafTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbRafTuru.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(171, 127);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstRaf
            // 
            this.lstRaf.FormattingEnabled = true;
            this.lstRaf.Location = new System.Drawing.Point(41, 183);
            this.lstRaf.Name = "lstRaf";
            this.lstRaf.Size = new System.Drawing.Size(205, 160);
            this.lstRaf.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(64, 127);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // RafKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 371);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstRaf);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbRafTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.label1);
            this.Name = "RafKayit";
            this.Text = "RafKayit";
            this.Load += new System.EventHandler(this.RafKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRafTuru;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstRaf;
        private System.Windows.Forms.Button btnSil;
    }
}