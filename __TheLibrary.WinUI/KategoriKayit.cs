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
    public partial class KategoriKayit : Form
    {
        public KategoriKayit()
        {
            InitializeComponent();
        }

        private void KategoriKayit_Load(object sender, EventArgs e)
        {
            lstTurler.DataSource = BLLCategories.GetAll();
            lstTurler.DisplayMember = "Name";
            lstTurler.ValueMember = "ID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(txtTurAdi.Text))
            {
                List<ECategories> categoryList = BLLCategories.GetAll();

                categoryList = (from l in categoryList
                                where l.Name.Trim().ToLower().Equals(txtTurAdi.Text.Trim().ToLower())
                                select l).ToList();

                if (categoryList.Count == 0)
                {
                    ECategories kategori = new ECategories();
                    kategori.Name = txtTurAdi.Text;
                    kategori.Description = TxtTurAciklamasi.Text;

                    if (BLLCategories.InsertNewCategory(kategori))
                    {
                        MessageBox.Show("Kategori kayıt işlemi başarıyla gerçekleşmiştir!");
                        lstTurler.DataSource = BLLCategories.GetAll();
                        txtTurAdi.Clear();
                        TxtTurAciklamasi.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kaydetmek istediğiniz tür zaten kayıtlıdır!");
                    txtTurAdi.Clear();
                    TxtTurAciklamasi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tür adı boş geçilemez!");
            }           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (lstTurler.SelectedItems.Count > 0)
            {
                int silinecekKategoriID = (int)lstTurler.SelectedValue;
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ECategories category = new ECategories();

                    category.ID = silinecekKategoriID;
                    if (BLLCategories.Delete(category))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        lstTurler.DataSource = BLLCategories.GetAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz türü seçiniz!");
            }
        }
    }
}
