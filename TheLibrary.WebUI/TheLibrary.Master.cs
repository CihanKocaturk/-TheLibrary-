using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheLibrary.WebUI
{
    public partial class TheLibrary : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserName"] != null)
            {
                string userFullName = Session["UserName"].ToString();
                if (!string.IsNullOrEmpty(userFullName))
                {
                    userName.InnerText = userFullName;
                }

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}