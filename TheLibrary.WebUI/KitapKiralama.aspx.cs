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
    public partial class KitapKiralama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<EBooks> bookList = BLLBooks.GetBookNames();
                if (bookList != null && bookList.Count > 0)
                {
                    bookList = (from l in bookList
                                where l.IsReturned == false
                                select l).ToList<EBooks>();
                }

                cmbVerilenKitap.DataSource = bookList;
                cmbVerilenKitap.DataTextField = "Name";
                cmbVerilenKitap.DataValueField = "ID";
                cmbVerilenKitap.ClearSelection();
                cmbVerilenKitap.DataBind();

                cmbMembers.DataSource = BLLMembers.GetMemberNames();
                cmbMembers.DataTextField = "FullName";
                cmbMembers.DataValueField = "ID";
                cmbMembers.ClearSelection();
                cmbMembers.DataBind();

                cmbEmployees.DataSource = BLLEmployees.GetEmployeeNames();
                cmbEmployees.DataTextField = "FullName";
                cmbEmployees.DataValueField = "ID";
                cmbEmployees.ClearSelection();
                cmbEmployees.DataBind();
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            List<EBooks> bookList = BLLBooks.GetBookNames();
            if (bookList != null && bookList.Count > 0)
            {
                bookList = (from l in bookList
                            where l.IsReturned == false
                            select l).ToList<EBooks>();
            }

            cmbVerilenKitap.DataSource = bookList;
            cmbVerilenKitap.DataTextField = "Name";
            cmbVerilenKitap.DataValueField = "ID";
            cmbVerilenKitap.ClearSelection();
            cmbVerilenKitap.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpExpireDate.Text))
            {
                EBorrowedBooks borrowedBook = new EBorrowedBooks();
                borrowedBook.Book = new EBooks();
                borrowedBook.Member = new EMembers();
                borrowedBook.Employee = new EEmployees();
                borrowedBook.Book.ID = Convert.ToInt32(cmbVerilenKitap.SelectedValue);
                borrowedBook.Employee.ID = Convert.ToInt32(cmbEmployees.SelectedValue);
                borrowedBook.Member.ID = Convert.ToInt32(cmbMembers.SelectedValue);
                borrowedBook.DateOfBorrow = DateTime.Now;
                

                string[] alinacakTarArr = dtpExpireDate.Text.Split(new string[] { "." }, StringSplitOptions.None);               
                borrowedBook.ExpireDate = new DateTime(int.Parse(alinacakTarArr[2]), int.Parse(alinacakTarArr[1]), int.Parse(alinacakTarArr[0]));

                    if (borrowedBook.ExpireDate > DateTime.Now)
                    {
                        if (BLLBorrowedBooks.InsertBorrowedBook(borrowedBook))
                        {

                            Response.Write("<script>alert('Kayıt işleminiz başarıyla gerçekleşmiştir.')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Hata Oluştu!')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Kitap Teslim Tarihi, alınan tarihten eski olamaz!')</script>");
                    }             
                dtpExpireDate.Text = String.Empty;
                cmbEmployees.ClearSelection();
                cmbMembers.ClearSelection();
                cmbVerilenKitap.ClearSelection();
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }
        }
    }
}