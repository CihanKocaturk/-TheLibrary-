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
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(Request.QueryString["categoryID"].ToString());

            ECategories category = new ECategories();
            category = BLLCategories.GetIdOnly(categoryID);
            if (!IsPostBack)
            {
                txtTurAdi.Text = category.Name;
                TxtTurAciklamasi.Text = category.Description;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTurAdi.Text))
            {
                ECategories guncellenecek = new ECategories();
                guncellenecek.ID = int.Parse(Request.QueryString["categoryID"]);
                guncellenecek.Name = txtTurAdi.Text;
                guncellenecek.Description = TxtTurAciklamasi.Text;
                bool sonuc = BLLCategories.Update(guncellenecek);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                    Response.Redirect("Kategoriler.aspx?scs=1");
                }
                else
                {
                    Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Tür adı boş geçilemez!')</script>");
            }
        }
    }
}