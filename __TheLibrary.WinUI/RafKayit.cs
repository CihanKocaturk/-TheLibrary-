using __TheLibrary.BLL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __TheLibrary.WinUI
{
    public partial class RafKayit : Form
    {
        public RafKayit()
        {
            InitializeComponent();
        }

        private void RafKayit_Load(object sender, EventArgs e)
        {
            cmbRafTuru.DataSource = BLLCategories.GetAll();
            cmbRafTuru.DisplayMember = "Name";
            cmbRafTuru.ValueMember = "ID";

            lstRaf.DataSource = BLLShelf.GetAll();
            lstRaf.DisplayMember = "ShelfNo";
            lstRaf.ValueMember = "ID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRafNo.Text))
            {
                List<EShelf> shelfList = BLLShelf.GetAll();

                shelfList = (from l in shelfList
                             where l.ShelfNo.Trim().ToLower().Equals(txtRafNo.Text.Trim().ToLower())
                             select l).ToList();
                if (shelfList.Count == 0)
                {
                    EShelf shelf = new EShelf();
                    shelf.Category = new ECategories();
                    shelf.ShelfNo = txtRafNo.Text;
                    shelf.Category.ID = Convert.ToInt32(cmbRafTuru.SelectedValue);

                    if (BLLShelf.InsertNewShelf(shelf))
                    {
                        MessageBox.Show("Yeni raf kayıt işlemi başarıyla tamamlanmıştır!");
                        lstRaf.DataSource = BLLShelf.GetAll();
                        txtRafNo.Clear();
                        txtRafNo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Kaydetmek istediğiniz raf zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Raf numarası boş geçilemez!");
            }

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {            
            if (lstRaf.SelectedItems.Count > 0)
            {
                int silinecekShelfID = (int)lstRaf.SelectedValue;

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EShelf shelf = new EShelf();

                    shelf.ID = silinecekShelfID;
                    if (BLLShelf.Delete(shelf))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        lstRaf.DataSource = BLLShelf.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz rafı seçiniz!");
            }
        }
    }
}
