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
    public partial class Raflar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Request.QueryString["ID"] != null)
            {
                EShelf shelf = new EShelf();
                shelf.ID = int.Parse(Request.QueryString["ID"]);
                bool sonuc = BLLShelf.Delete(shelf);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Silindi!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Hay Aksi! Silinemedi!')</script>");
                }

            }

            rptRaflar.DataSource = BLLShelf.GetAll();
            rptRaflar.DataBind();

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