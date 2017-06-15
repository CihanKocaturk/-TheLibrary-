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
    public partial class RafKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmbRafTuru.DataSource = BLLCategories.GetAll();
                cmbRafTuru.DataTextField = "Name";
                cmbRafTuru.DataValueField = "ID";
                cmbRafTuru.DataBind();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRafNo.Text))
            {
                List<EShelf> shelfList = BLLShelf.GetAll();

                shelfList = (from l in shelfList
                             where l.ShelfNo.Trim().ToLower().Equals(txtRafNo.Text.Trim().ToLower())
                             select l).ToList();
                if (shelfList.Count == 0)
                {
                    EShelf shelf = new EShelf();
                    shelf.Category = new ECategories();
                    shelf.ShelfNo = txtRafNo.Text;
                    shelf.Category.ID = Convert.ToInt32(cmbRafTuru.SelectedValue);

                    if (BLLShelf.InsertNewShelf(shelf))
                    {
                        Response.Write("<script>alert('Raf kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kaydetmek istediğiniz raf zaten kayıtlı!')</script>");
                }
                txtRafNo.Text = String.Empty;
                cmbRafTuru.ClearSelection();
                txtRafNo.Focus();
            }
            else
            {
                Response.Write("<script>alert('Raf numarası boş geçilemez!')</script>");
            }
        }
    }
}