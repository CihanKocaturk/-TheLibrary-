using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLBorrowedBooks
    {
        public static bool InsertBorrowedBook(EBorrowedBooks borrowedBook)
        {
            if (borrowedBook.Book.ID < 1 || borrowedBook.DateOfBorrow == null || borrowedBook.Employee.ID < 1 || borrowedBook.ExpireDate == null || borrowedBook.Member.ID < 1)
            {
                return false;
            }
            else
            {
                DALBorrowedBooks.InsertBorrowedBook(borrowedBook);
                return true;
            }
        }

        public static List<EBorrowedBooks> GetAll()
        {
            return DALBorrowedBooks.GetAll();
        }

        public static EBorrowedBooks GetIdOnly(int borrowedBokkID)
        {
            return DALBorrowedBooks.GetIdOnly(borrowedBokkID);
        }

        public static bool Update(EBorrowedBooks borrowedbook)
        {
            DALBorrowedBooks.Update(borrowedbook);
            return true;
        }
    }
}
