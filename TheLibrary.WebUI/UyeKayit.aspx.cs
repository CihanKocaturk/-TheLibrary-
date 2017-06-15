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
    public partial class UyeKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtAdi.Text) & !string.IsNullOrEmpty(txtSoyadi.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text))
            {
                if (txtTCNo.Text.Length == 11)
                {
                    List<EMembers> memberList = BLLMembers.GetAll();

                    memberList = (from l in memberList
                                  where l.TCNo.Trim().ToLower().Equals(txtTCNo.Text.Trim().ToLower())
                                  select l).ToList();
                    if (memberList.Count == 0)
                    {
                        EMembers member = new EMembers();
                        member.TCNo = txtTCNo.Text;
                        member.FirstName = txtAdi.Text;
                        member.LastName = txtSoyadi.Text;
                        member.Phone = txtCepNo.Text;
                        member.Address = txtAdres.Text;

                        if (BLLMembers.InsertNewMember(member))
                        {
                            Response.Write("<script>alert('Üye kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Hata Oluştu!')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Kaydetmek istediğiniz üye zaten kayıtlı!')</script>");
                    }

                    txtTCNo.Text = String.Empty;
                    txtAdi.Text = String.Empty;
                    txtSoyadi.Text = String.Empty;
                    txtCepNo.Text = String.Empty;
                    txtAdres.Text = String.Empty;
                    txtTCNo.Focus();
                }
                else
                {
                    Response.Write("<script>alert('TC Kimlik Numarası 11 hane olmalıdır!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }     
        }
    }
}