using __TheLibrary.BLL;
using __TheLibrary.DAL;
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
    public partial class KitapKayıt : Form
    {
        public KitapKayıt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLBooks.GetAll();


            cmbKitapYazari.DataSource = BLLAuthors.GetAll();
            cmbKitapYazari.DisplayMember = "FullName";
            cmbKitapYazari.ValueMember = "ID";

            cmbTur.DataSource = BLLCategories.GetAll();
            cmbTur.DisplayMember = "Name";
            cmbTur.ValueMember = "ID";

            cmbRafNo.DataSource = BLLShelf.GetAll();
            cmbRafNo.DisplayMember = "ShelfNo";
            cmbRafNo.ValueMember = "ID";

            cmbYayinEvi.DataSource = BLLPublisher.GetAll();
            cmbYayinEvi.DisplayMember = "Name";
            cmbYayinEvi.ValueMember = "ID";
        }

        private void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.SelectedIndex = -1;
                }
                else if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKitapAdi.Text) & !string.IsNullOrEmpty(txtISBNNo.Text) & cmbKitapYazari.SelectedIndex != -1 & cmbRafNo.SelectedIndex != -1 & cmbTur.SelectedIndex != -1 & cmbYayinEvi.SelectedIndex != -1)
            {
                DateTime dtpBasimTar = Convert.ToDateTime(dtpBasimTarihi.Text);
                if (dtpBasimTar <= DateTime.Now)
                {
                    List<EBooks> bookList = BLLBooks.GetAll();

                    bookList = (from l in bookList
                                where l.ISBNNO.Trim().ToLower().Equals(txtISBNNo.Text.Trim().ToLower())
                                select l).ToList();
                    if (bookList.Count == 0)
                    {
                        EBooks book = new EBooks();
                        book.Author = new EAuthors();
                        book.Shelf = new EShelf();

                        book.Name = txtKitapAdi.Text;
                        book.Author.ID = Convert.ToInt32(cmbKitapYazari.SelectedValue);
                        book.Shelf.ID = Convert.ToInt32(cmbRafNo.SelectedValue);
                        book.ISBNNO = txtISBNNo.Text;
                        book.DateOfPublish = dtpBasimTarihi.Value;

                        EBookCategory bookCategory = new EBookCategory();
                        bookCategory.CategoryID = Convert.ToInt32(cmbTur.SelectedValue);
                        bookCategory.BookID = BLLBooks.InsertNewBook(book);

                        EBookPublisher bookPublisher = new EBookPublisher();
                        bookPublisher.PublisherID = Convert.ToInt32(cmbYayinEvi.SelectedValue);
                        bookPublisher.BookID = bookCategory.BookID;

                        if (BLLBookCategory.InsertNewBookCategory(bookCategory) & BLLBookPublisher.InsertNewBookPublisher(bookPublisher))
                        {
                            MessageBox.Show("Kitap kayıt işleminiz başarıyla gerçekleşmiştir!");
                            dataGridView1.DataSource = BLLBooks.GetAll();
                            Clear();
                            txtKitapAdi.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girmiş olduğunuz ISBN Numaralı kitap zaten kayıtlı!");
                    }                    
                }
                else
                {
                    MessageBox.Show("Basım Tarihi Bugünün Tarihinden Büyük Olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
            }
        }

        EBooks seciliKitap;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliKitap = (EBooks)dataGridView1.SelectedRows[0].DataBoundItem;

            txtKitapAdi.Text = seciliKitap.Name;
            txtISBNNo.Text = seciliKitap.ISBNNO;
            cmbKitapYazari.SelectedValue = seciliKitap.Author.ID;
            cmbRafNo.Text = seciliKitap.Shelf.ShelfNo;
            dtpBasimTarihi.Value = seciliKitap.DateOfPublish;
            cmbTur.SelectedValue = seciliKitap.Category.ID;
            cmbYayinEvi.SelectedValue = seciliKitap.Publisher.ID;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKitap != null)
            {
                if (!string.IsNullOrEmpty(txtKitapAdi.Text) & !string.IsNullOrEmpty(txtISBNNo.Text) & cmbKitapYazari.SelectedIndex != -1 & cmbRafNo.SelectedIndex != -1 & cmbTur.SelectedIndex != -1 & cmbYayinEvi.SelectedIndex != -1)
                {
                    DateTime dtpBasimTar = Convert.ToDateTime(dtpBasimTarihi.Text);
                    if (dtpBasimTar <= DateTime.Now)
                    {
                        EBooks book = new EBooks();
                        book.Author = new EAuthors();
                        book.Shelf = new EShelf();
                        book.Category = new ECategories();
                        book.Publisher = new EPublisher();
                        book.ID = Convert.ToInt32(seciliKitap.ID);
                        book.Name = txtKitapAdi.Text;
                        book.Author.ID = Convert.ToInt32(cmbKitapYazari.SelectedValue);
                        book.Shelf.ID = Convert.ToInt32(cmbRafNo.SelectedValue);
                        book.Category.ID = Convert.ToInt32(cmbTur.SelectedValue);
                        book.Publisher.ID = Convert.ToInt32(cmbYayinEvi.SelectedValue);
                        book.DateOfPublish = dtpBasimTarihi.Value;
                        book.ISBNNO = txtISBNNo.Text;

                        bool sonuc = BLLBooks.Update(book);

                        if (sonuc)
                        {
                            MessageBox.Show("Güncelleme başarılı!");
                            dataGridView1.DataSource = BLLBooks.GetAll();
                            Clear();
                            txtKitapAdi.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Basım Tarihi Bugünün Tarihinden Büyük Olamaz!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi yapmak istediğiniz kitabın üzerine çift tıklayarak seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EBooks silinecekKitap = (EBooks)dataGridView1.SelectedRows[0].DataBoundItem;
           
            if (silinecekKitap != null)
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EBooks book = new EBooks();

                    book.ID = silinecekKitap.ID;
                    if (BLLBooks.Delete(book))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        dataGridView1.DataSource = BLLBooks.GetAll();
                        Clear();
                        txtKitapAdi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu");
                    }
                }              
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçiniz!");
            }
        }
    }
}
