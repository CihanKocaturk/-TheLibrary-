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
    public partial class KitapGuncelle : System.Web.UI.Page
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

                int bookID = Convert.ToInt32(Request.QueryString["bookID"].ToString());


                EBooks book = new EBooks();
                book.Author = new EAuthors();
                book.Shelf = new EShelf();
                book.Category = new ECategories();
                book.Publisher = new EPublisher();
                
                book = BLLBooks.GetIdOnly(bookID);
                txtKitapAdi.Text = book.Name;
                txtISBNNo.Text = book.ISBNNO;              

                cmbRafNo.SelectedValue = book.Shelf.ID.ToString();
                cmbKitapYazari.SelectedValue = book.Author.ID.ToString();
                cmbTur.SelectedValue = book.Category.ID.ToString();
                cmbYayinEvi.SelectedValue = book.Publisher.ID.ToString();

                dtpBasimTarihi.Text = book.DateOfPublish.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKitapAdi.Text) & !string.IsNullOrEmpty(txtISBNNo.Text) & !string.IsNullOrEmpty(dtpBasimTarihi.Text))
            {
                DateTime dtpBasimTar = Convert.ToDateTime(dtpBasimTarihi.Text);
                if (dtpBasimTar <= DateTime.Now)
                {
                    EBooks guncellenecek = new EBooks();
                    guncellenecek.Author = new EAuthors();
                    guncellenecek.Shelf = new EShelf();
                    guncellenecek.Category = new ECategories();
                    guncellenecek.Publisher = new EPublisher();

                    guncellenecek.ID = int.Parse(Request.QueryString["bookID"]);
                    guncellenecek.Shelf.ID = Convert.ToInt32(cmbRafNo.SelectedValue);
                    guncellenecek.Category.ID = Convert.ToInt32(cmbTur.SelectedValue);
                    guncellenecek.Publisher.ID = Convert.ToInt32(cmbYayinEvi.SelectedValue);
                    guncellenecek.Author.ID = Convert.ToInt32(cmbKitapYazari.SelectedValue);

                    guncellenecek.Name = txtKitapAdi.Text;
                    guncellenecek.ISBNNO = txtISBNNo.Text;

                    guncellenecek.DateOfPublish = DateTime.Parse(dtpBasimTarihi.Text);

                    bool sonuc = BLLBooks.Update(guncellenecek);
                    if (sonuc)
                    {
                        Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                        Response.Redirect("Kitaplar.aspx?scs=1");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                    }
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