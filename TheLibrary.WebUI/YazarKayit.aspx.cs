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
    public partial class YazarKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYazarAdi.Text) & !string.IsNullOrEmpty(txtYazarSoyadi.Text))
            {
                List<EAuthors> authorList = BLLAuthors.GetAll();

                authorList = (from l in authorList
                              where l.FirstName.Trim().ToLower().Equals(txtYazarAdi.Text.Trim().ToLower())
                              && l.LastName.Trim().ToLower().Equals(txtYazarSoyadi.Text.Trim().ToLower())
                              select l).ToList();

                if (authorList.Count == 0)
                {
                    EAuthors author = new EAuthors();
                    author.FirstName = txtYazarAdi.Text;
                    author.LastName = txtYazarSoyadi.Text;

                    if (BLLAuthors.InsertNewAuthor(author))
                    {
                        Response.Write("<script>alert('Yazar kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kaydetmek istediğiniz yazar zaten kayıtlıdır!')</script>");
                }
                txtYazarAdi.Text = String.Empty;
                txtYazarSoyadi.Text = String.Empty;
                txtYazarAdi.Focus();
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }           
        }
    }
}