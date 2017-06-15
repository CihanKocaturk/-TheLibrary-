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
    public partial class KategoriKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTurAdi.Text))
            {
                List<ECategories> categoryList = BLLCategories.GetAll();

                categoryList = (from l in categoryList
                                where l.Name.Trim().ToLower().Equals(txtTurAdi.Text.Trim().ToLower())
                                select l).ToList();

                if (categoryList.Count == 0)
                {
                    ECategories kategori = new ECategories();
                    kategori.Name = txtTurAdi.Text;
                    kategori.Description = TxtTurAciklamasi.Text;

                    if (BLLCategories.InsertNewCategory(kategori))
                    {
                        Response.Write("<script>alert('Tür kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kaydetmek istediğiniz tür zaten kayıtlı!')</script>");
                }
                txtTurAdi.Text = String.Empty;
                TxtTurAciklamasi.Text = String.Empty;
                txtTurAdi.Focus();
            }
            else
            {
                Response.Write("<script>alert('Tür adı boş geçilemez!')</script>");
            }
        }
    }
}