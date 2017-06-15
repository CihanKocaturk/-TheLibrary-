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
    public partial class Yayinevi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYayineviAdi.Text))
            {
                List<EPublisher> publisherList = BLLPublisher.GetAll();

                publisherList = (from l in publisherList
                                 where l.Name.Trim().ToLower().Equals(txtYayineviAdi.Text.Trim().ToLower())
                                 select l).ToList();
                if (publisherList.Count == 0)
                {
                    if (BLLPublisher.InsertNewPublisher(new EPublisher(0, txtYayineviAdi.Text)))
                    {
                        Response.Write("<script>alert('Yayınevi kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kaydetmek istediğiniz yayınevi zaten kayıtlıdır!')</script>");
                }
                txtYayineviAdi.Text = String.Empty;
                txtYayineviAdi.Focus();
            }
            else
            {
                Response.Write("<script>alert('Yayınevi adı boş geçilemez!')</script>");
            }
        }
    }
}