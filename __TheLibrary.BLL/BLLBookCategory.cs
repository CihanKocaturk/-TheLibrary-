using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLBookCategory
    {
        public static bool InsertNewBookCategory(EBookCategory bookcategory)
        {
            if (bookcategory.CategoryID < 1)
            {
                return false;
            }
            else
            {
                DALBookCategory.InsertNewBooksCategory(bookcategory);
                return true;
            }
        }
    }
}
