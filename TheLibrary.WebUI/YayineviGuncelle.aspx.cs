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
    public partial class YayineviGuncelle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int publisherID = Convert.ToInt32(Request.QueryString["yayineviID"].ToString());

                EPublisher publisher = new EPublisher();
                publisher = BLLPublisher.GetIdOnly(publisherID);
                txtYayineviAdi.Text = publisher.Name;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYayineviAdi.Text))
            {
                EPublisher guncellenecek = new EPublisher();
                guncellenecek.ID = int.Parse(Request.QueryString["yayineviID"]);
                guncellenecek.Name = txtYayineviAdi.Text;
                bool sonuc = BLLPublisher.Update(guncellenecek);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                    Response.Redirect("Yayinevleri.aspx?scs=1");
                }
                else
                {
                    Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Yayınevi adı boş geçilemez!')</script>");
            }
            
            
        }
    }
}