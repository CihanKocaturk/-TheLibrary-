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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            List<EEmployees> userList = BLLEmployees.GetAll();
            string userName = txtKullaniciAdi.Text;
            string password = txtSifre.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (userList != null && userList.Count() > 0)
                {
                    userList = (from l in userList
                                where l.UserName.Trim().ToLower().Equals(userName.Trim().ToLower())
                                && l.Password.Trim().ToLower().Equals(password.Trim().ToLower())
                                select l).ToList<EEmployees>();
                    if (userList != null && userList.Count() > 0)
                    {
                        EEmployees user = new EEmployees();
                        user = userList.FirstOrDefault();
                        Session.Add("UserName", user.FullName);
                        
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Kullanıcı adı yada şifreyi yanlış girdiniz!')</script>");
                        txtKullaniciAdi.Text = String.Empty;
                        txtSifre.Text = String.Empty;
                    }
                }
                else
                {
                    Response.Write("<script>alert('Sisteme kayıtlı kullanıcı bulunamadı!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı adı yada şifre boş geçilemez!')</script>");
                txtSifre.Text = String.Empty;
            }
        }
    }
}