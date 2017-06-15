using __TheLibrary.BLL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheLibrary.WebUI
{
    public partial class KitapEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cmbKitapYazari.DataSource = BLLAuthors.GetAll();
                cmbKitapYazari.DataTextField = "FullName";
                cmbKitapYazari.DataValueField = "ID";
                cmbKitapYazari.DataBind();

                cmbTur.DataSource = BLLCategories.GetAll();
                cmbTur.DataTextField = "Name";
                cmbTur.DataValueField = "ID";
                cmbTur.DataBind();

                cmbRafNo.DataSource = BLLShelf.GetAll();
                cmbRafNo.DataTextField = "ShelfNo";
                cmbRafNo.DataValueField = "ID";
                cmbRafNo.DataBind();

                cmbYayinEvi.DataSource = BLLPublisher.GetAll();
                cmbYayinEvi.DataTextField = "Name";
                cmbYayinEvi.DataValueField = "ID";
                cmbYayinEvi.DataBind();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKitapAdi.Text) & !string.IsNullOrEmpty(dtpBasimTarihi.Text) & !string.IsNullOrEmpty(txtISBNNo.Text))
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

                        string[] basimTarArr = dtpBasimTarihi.Text.Split(new string[] { "." }, StringSplitOptions.None);
                        book.DateOfPublish = new DateTime(int.Parse(basimTarArr[2]), int.Parse(basimTarArr[1]), int.Parse(basimTarArr[0]));

                        EBookCategory bookCategory = new EBookCategory();
                        bookCategory.CategoryID = Convert.ToInt32(cmbTur.SelectedValue);
                        bookCategory.BookID = BLLBooks.InsertNewBook(book);

                        EBookPublisher bookPublisher = new EBookPublisher();
                        bookPublisher.PublisherID = Convert.ToInt32(cmbYayinEvi.SelectedValue);
                        bookPublisher.BookID = bookCategory.BookID;

                        if (BLLBookCategory.InsertNewBookCategory(bookCategory) & BLLBookPublisher.InsertNewBookPublisher(bookPublisher))
                        {
                            Response.Write("<script>alert('Kitap kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Hata Oluştu!')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Girmiş olduğunuz ISBN Numaralı kitap zaten kayıtlı!')</script>");
                    }


                    txtKitapAdi.Text = String.Empty;
                    txtISBNNo.Text = String.Empty;
                    dtpBasimTarihi.Text = String.Empty;
                    cmbKitapYazari.ClearSelection();
                    cmbRafNo.ClearSelection();
                    cmbTur.ClearSelection();
                    cmbYayinEvi.ClearSelection();
                    txtKitapAdi.Focus();
                }
                else
                {
                    Response.Write("<script>alert('Basım Tarihi Bugünün Tarihinden Büyük Olamaz!')</script>");
                    dtpBasimTarihi.Text = String.Empty;
                }
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }
        }
    }
}