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
    public partial class YazarGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int authorID = Convert.ToInt32(Request.QueryString["yazarID"].ToString());

                EAuthors author = new EAuthors();
                author = BLLAuthors.GetIdOnly(authorID);
                txtYazarAdi.Text = author.FirstName;
                txtYazarSoyadi.Text = author.LastName;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYazarAdi.Text) & !string.IsNullOrEmpty(txtYazarSoyadi.Text))
            {
                List<EAuthors> authorList = new List<EAuthors>();
                authorList = BLLAuthors.GetAll();

                authorList = (from l in authorList
                              where l.FirstName.Trim().ToLower().Equals(txtYazarAdi.Text.Trim().ToLower())
                              && l.LastName.Trim().ToLower().Equals(txtYazarSoyadi.Text.Trim().ToLower())
                              select l).ToList();
                if (authorList.Count == 0)
                {
                    EAuthors guncellenecek = new EAuthors();
                    guncellenecek.ID = int.Parse(Request.QueryString["yazarID"]);
                    guncellenecek.FirstName = txtYazarAdi.Text;
                    guncellenecek.LastName = txtYazarSoyadi.Text;
                    bool sonuc = BLLAuthors.Update(guncellenecek);
                    if (sonuc)
                    {
                        Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                        Response.Redirect("Yazarlar.aspx?scs=1");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Aynı isimde kayıtlı yazar mevcuttur!')</script>");
                    Response.Redirect("Yazarlar.aspx?scs=1");
                }
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }
        }
    }
}