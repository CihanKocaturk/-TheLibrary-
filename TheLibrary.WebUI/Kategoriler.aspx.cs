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
    public partial class Kategoriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Request.QueryString["ID"] != null)
            {
                ECategories category = new ECategories();
                category.ID = int.Parse(Request.QueryString["ID"]);
                bool sonuc = BLLCategories.Delete(category);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Silindi!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Hay Aksi! Silinemedi!')</script>");
                }

            }

            rptKategoriler.DataSource = BLLCategories.GetAll();
            rptKategoriler.DataBind();

            if (Request.QueryString["scs"] != null)
            {
                int scsID = Convert.ToInt32(Request.QueryString["scs"].ToString());
                if (scsID == 1)
                {
                    Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                }
            }
        }
    }
}