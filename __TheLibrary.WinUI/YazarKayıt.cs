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
    public partial class YazarKayıt : Form
    {
        public YazarKayıt()
        {
            InitializeComponent();
        }

        void Listele()
        {
            foreach (EAuthors item in BLLAuthors.GetAll())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.FirstName;
                lvi.SubItems.Add(item.LastName).ToString();
                lvi.Tag = item.ID;
                lvYazar.Items.Add(lvi);
            }
        }

        private void YazarKayıt_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYazarAdi.Text) & !string.IsNullOrEmpty(txtYazarSoyadi.Text))
            {
                List<EAuthors> authorList = BLLAuthors.GetAll();

                authorList = (from l in authorList
                              where l.FirstName.Trim().ToLower().Equals(txtYazarAdi.Text.Trim().ToLower())
                              && l.LastName.Trim().ToLower().Equals(txtYazarSoyadi.Text.Trim().ToLower())
                              select l).ToList();

                if (authorList.Count == 0)
                {
                    EAuthors author = new EAuthors();
                    author.FirstName = txtYazarAdi.Text;
                    author.LastName = txtYazarSoyadi.Text;

                    bool sonuc = BLLAuthors.InsertNewAuthor(author);

                    if (sonuc)
                    {
                        MessageBox.Show("Yazar kayıt işlemi başarıyla gerçekleşmiştir!");
                        txtYazarAdi.Clear();
                        txtYazarSoyadi.Clear();
                        txtYazarAdi.Focus();
                        lvYazar.Items.Clear();
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Yazar zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz.Lütfen kontrol ediniz!");
            }
        }

        private void lvYazar_DoubleClick(object sender, EventArgs e)
        {
            int selectedAuthorID = (int)lvYazar.SelectedItems[0].Tag;

            EAuthors selectedAuthor = new EAuthors();
            selectedAuthor = BLLAuthors.GetIdOnly(selectedAuthorID);

            txtYazarAdi.Text = selectedAuthor.FirstName;
            txtYazarSoyadi.Text = selectedAuthor.LastName;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lvYazar.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtYazarAdi.Text) & !string.IsNullOrEmpty(txtYazarSoyadi.Text))
                {
                    EAuthors author = new EAuthors();
                    author.ID = Convert.ToInt32((int)lvYazar.SelectedItems[0].Tag);

                    author.FirstName = txtYazarAdi.Text;
                    author.LastName = txtYazarSoyadi.Text;

                    if (BLLAuthors.Update(author))
                    {
                        MessageBox.Show("Güncelleme başarılı!");
                        txtYazarAdi.Clear();
                        txtYazarSoyadi.Clear();
                        lvYazar.Items.Clear();
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi yapmak istediğiniz yazarı listeden çift tıklayarak seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvYazar.SelectedItems.Count > 0)
            {
                int selectedAuthorID = (int)lvYazar.SelectedItems[0].Tag;

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EAuthors silinecekYazar = new EAuthors();
                    silinecekYazar.ID = selectedAuthorID;
                    EAuthors author = new EAuthors();

                    author.ID = silinecekYazar.ID;
                    if (BLLAuthors.Delete(author))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        lvYazar.Items.Clear();
                        txtYazarAdi.Clear();
                        txtYazarSoyadi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz yazarı seçiniz.");
            }
        }
    }
}
