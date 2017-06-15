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
    public partial class KitapTeslimFormu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;                           
            
            if (Request.QueryString["ID"] != null)
            {
                EBorrowedBooks returnBook = new EBorrowedBooks();
                returnBook.ID = int.Parse(Request.QueryString["ID"]);
                returnBook = BLLBorrowedBooks.GetIdOnly(returnBook.ID);
                returnBook.DateOfReturn = DateTime.Now;
                returnBook.IsReturned = false;
                

                bool sonuc = BLLBorrowedBooks.Update(returnBook);
                if (sonuc)
                {
                    Response.Write("<script>alert('Harika! Kitap Teslim Alındı!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Bir hata oluştu!')</script>");
                }
            }

            List<EBorrowedBooks> bookList = BLLBorrowedBooks.GetAll();
            if (bookList != null && bookList.Count > 0)
            {
                bookList = (from l in bookList
                            where l.IsReturned == true
                            select l).ToList<EBorrowedBooks>();
            }
            else
            {
                Response.Write("<script>alert('Teslim alınacak kitap bulunamadı!')</script>");
            }
            rptKitaplar.DataSource = bookList;
            rptKitaplar.DataBind();
        }
    }
}