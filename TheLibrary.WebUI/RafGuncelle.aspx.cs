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
    public partial class RafGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmbRafTuru.DataSource = BLLCategories.GetAll();
                cmbRafTuru.DataTextField = "Name";
                cmbRafTuru.DataValueField = "ID";  
                cmbRafTuru.DataBind();

                int shelfID = Convert.ToInt32(Request.QueryString["shelfID"].ToString());

                EShelf shelf = new EShelf(); 
                shelf.Category = new ECategories();
                shelf = BLLShelf.GetIdOnly(shelfID);;
                txtRafNo.Text = shelf.ShelfNo;
                cmbRafTuru.SelectedValue = shelf.Category.ID.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRafNo.Text))
            {
                EShelf guncellenecek = new EShelf();
                guncellenecek.Category = new ECategories();
                guncellenecek.ID = int.Parse(Request.QueryString["shelfID"]);
                guncellenecek.ShelfNo = txtRafNo.Text;
                guncellenecek.Category.ID = Convert.ToInt32(cmbRafTuru.SelectedValue);

                bool sonuc = BLLShelf.Update(guncellenecek);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                    Response.Redirect("Raflar.aspx?scs=1");
                }
                else
                {
                    Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Raf numarası boş geçilemez.')</script>");
            }
        }
    }
}