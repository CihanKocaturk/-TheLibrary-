﻿namespace __TheLibrary.WinUI
{
    partial class Kitap_Türleri
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
            this.SuspendLayout();
            // 
            // lstTurler
            // 
            this.lstTurler.FormattingEnabled = true;
            this.lstTurler.Location = new System.Drawing.Point(36, 57);
            this.lstTurler.Name = "lstTurler";
            this.lstTurler.Size = new System.Drawing.Size(212, 147);
            this.lstTurler.TabIndex = 10;
            // 
            // Kitap_Türleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstTurler);
            this.Name = "Kitap_Türleri";
            this.Text = "Kitap_Türleri";
            this.Load += new System.EventHandler(this.Kitap_Türleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTurler;
    }
}