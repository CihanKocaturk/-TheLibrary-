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
    public partial class KitapDurumRaporu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EBorrowedBooks> borrowedBookList = BLLBorrowedBooks.GetAll();

            if (chbDisarda.Checked)
            {
                chbGecTeslim.Enabled = chbGecikmis.Enabled = false;
                if (borrowedBookList != null && borrowedBookList.Count > 0)
                {
                    borrowedBookList = (from l in borrowedBookList
                                where l.IsReturned == true
                                select l).ToList<EBorrowedBooks>();
                    if (borrowedBookList.Count > 0)
                    {
                        rptKitaplar.DataSource = borrowedBookList;
                        rptKitaplar.DataBind();
                    }
                }
            }
            else if (chbGecikmis.Checked)
            {
                chbGecTeslim.Enabled = chbDisarda.Enabled = false;
                if (borrowedBookList != null && borrowedBookList.Count > 0)
                {
                    borrowedBookList = (from l in borrowedBookList
                                where new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) >= new DateTime(l.ExpireDate.Year, l.ExpireDate.Month, l.ExpireDate.Day)
                                && l.IsReturned == true
                                select l).ToList<EBorrowedBooks>();
                    if (borrowedBookList.Count > 0)
                    {
                        rptKitaplar.DataSource = borrowedBookList;
                        rptKitaplar.DataBind();
                    }
                    else
                    {
                        rptKitaplar.DataSource = borrowedBookList;
                        rptKitaplar.DataBind();
                    }
                }
            }
            else if (chbGecTeslim.Checked)
            {
                chbGecikmis.Enabled = chbDisarda.Enabled = false;
                if (borrowedBookList != null && borrowedBookList.Count > 0)
                {
                    borrowedBookList = (from l in borrowedBookList
                                where l.DateOfReturn.HasValue
                                && new DateTime(l.DateOfReturn.Value.Year, l.DateOfReturn.Value.Month, l.DateOfReturn.Value.Day) >= new DateTime(l.ExpireDate.Year, l.ExpireDate.Month, l.ExpireDate.Day)
                                && l.IsReturned == false
                                select l).ToList<EBorrowedBooks>();
                    if (borrowedBookList.Count > 0)
                    {
                        rptKitaplar.DataSource = borrowedBookList;
                        rptKitaplar.DataBind();
                    }
                    else
                    {
                        rptKitaplar.DataSource = borrowedBookList;
                        rptKitaplar.DataBind();
                    }
                }
            }
            else
            {
                chbGecTeslim.Enabled = chbGecikmis.Enabled = chbDisarda.Enabled = true;
                rptKitaplar.DataSource = borrowedBookList;
                rptKitaplar.DataBind();
            }
        }
    }
}