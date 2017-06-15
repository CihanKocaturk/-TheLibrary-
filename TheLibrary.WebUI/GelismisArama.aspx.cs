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
    public partial class GelismisArama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            if (chbRaf.Checked == true)
            {
                panelRaf.Enabled = true;
            }
            else
            {
                panelRaf.Enabled = false;

            }

            if (chbTur.Checked == true)
            {
                panelTur.Enabled = true;
            }
            else
            {
                panelTur.Enabled = false;

            }

            if (chbYayinevi.Checked == true)
            {
                panelYayinEvi.Enabled = true;
            }
            else
            {
                panelYayinEvi.Enabled = false;

            }
            if (chbYazar.Checked == true)
            {
                panelKitapYazari.Enabled = true;
            }
            else
            {
                panelKitapYazari.Enabled = false;

            }
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            List<EBooks> bookList = BLLBooks.GetAll();
            int selectedAuthorID = int.Parse(cmbKitapYazari.SelectedValue.ToString());
            int selectedShelfID = int.Parse(cmbRafNo.SelectedValue.ToString());
            int selectedCategoryID = int.Parse(cmbTur.SelectedValue.ToString());
            int selectedPublisherID = int.Parse(cmbYayinEvi.SelectedValue.ToString());


            if (bookList != null && bookList.Count > 0)
            {
                if (chbYazar.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Author.ID == selectedAuthorID
                                select l).ToList<EBooks>();
                }

                if (chbYayinevi.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Publisher.ID == selectedPublisherID
                                select l).ToList<EBooks>();
                }

                if (chbTur.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Category.ID == selectedCategoryID
                                select l).ToList<EBooks>();
                }

                if (chbRaf.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Shelf.ID == selectedShelfID
                                select l).ToList<EBooks>();
                }

                if (bookList.Count > 0)
                {
                    rptKitaplar.DataSource = bookList;
                    rptKitaplar.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Aradığınız kriterlere uygun kitap bulunmamaktadır !')</script>");
                    rptKitaplar.DataSource = bookList;
                    rptKitaplar.DataBind(); ;
                }
            }
        }
    }
}