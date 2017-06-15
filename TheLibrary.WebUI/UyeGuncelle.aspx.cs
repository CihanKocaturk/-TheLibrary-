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
    public partial class UyeGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int memberID = Convert.ToInt32(Request.QueryString["memberID"].ToString());

                EMembers member = new EMembers();
                member = BLLMembers.GetIdOnly(memberID);
                txtAdi.Text = member.FirstName;
                txtSoyadi.Text = member.LastName;
                txtTCNo.Text = member.TCNo;
                txtCepNo.Text = member.Phone;
                txtAdres.Text = member.Address;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTCNo.Text.Length == 11)
            {
                if (!string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtAdi.Text) & !string.IsNullOrEmpty(txtSoyadi.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text))
                {
                    EMembers guncellenecek = new EMembers();
                    guncellenecek.ID = int.Parse(Request.QueryString["memberID"]);
                    guncellenecek.TCNo = txtTCNo.Text;
                    guncellenecek.FirstName = txtAdi.Text;
                    guncellenecek.LastName = txtSoyadi.Text;
                    guncellenecek.Phone = txtCepNo.Text;
                    guncellenecek.Address = txtAdres.Text;
                    bool sonuc = BLLMembers.Update(guncellenecek);
                    if (sonuc)
                    {
                        Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                        Response.Redirect("Uyeler.aspx?scs=1");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('TC kimlik numarası 11 hane olmalıdır!')</script>");
            }
            
        }

    }
}