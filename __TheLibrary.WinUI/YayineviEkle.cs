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
    public partial class YayineviEkle : Form
    {
        public YayineviEkle()
        {
            InitializeComponent();
        }

        private void YayineviEkle_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = BLLPublisher.GetAll();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYayineviAdi.Text))
            {
                List<EPublisher> publisherList = BLLPublisher.GetAll();
                publisherList = (from l in publisherList
                                 where l.Name.Trim().ToLower().Equals(txtYayineviAdi.Text.Trim().ToLower())
                                 select l).ToList();
                if (publisherList.Count == 0)
                {
                    EPublisher publisher = new EPublisher();
                    publisher.Name = txtYayineviAdi.Text;

                    if (BLLPublisher.InsertNewPublisher(new EPublisher(0, txtYayineviAdi.Text)))
                    {
                        MessageBox.Show("Yeni yayınevi kayıt işlemi başarıyla tamamlanmıştır!");
                        txtYayineviAdi.Clear();
                        listBox1.DataSource = BLLPublisher.GetAll();
                        txtYayineviAdi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Kaydetmek istediğiniz yayınevi zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Yayınevi adı boş geçilemez!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItems.Count > 0)
            {
                int silinecekPublisherID = (int)listBox1.SelectedValue;
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EPublisher publisher = new EPublisher();

                    publisher.ID = silinecekPublisherID;
                    if (BLLPublisher.Delete(publisher))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        listBox1.DataSource = BLLPublisher.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz yayınevini seçiniz!");
            }
        }
    }
}
