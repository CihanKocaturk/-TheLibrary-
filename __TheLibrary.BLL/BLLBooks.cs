using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLBooks
    {
        public static int InsertNewBook(EBooks book)
        {
            int bookID = DALBooks.InsertNewBook(book);

            return bookID;
        }

        public static List<EBooks> GetAll()
        {
            return DALBooks.GetAll();
        }

        public static EBooks GetIdOnly(int bookID)
        {
            return DALBooks.GetIdOnly(bookID);
        }

        public static List<EBooks> GetBookNames()
        {           
            return DALBooks.GetBookNames();                  
        }

        public static bool Update(EBooks book)
        {
            DALBooks.Update(book);
            return true;
        }

        public static bool Delete(EBooks book)
        {
            DALBooks.Delete(book);
            return true;
        }
    }
}
