using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLShelf
    {
        public static bool InsertNewShelf(EShelf shelf)
        {
            if (shelf.ShelfNo == "" || shelf.Category.ID < 1)
            {
                return false;
            }
            else
            {
                DALShelf.InsertNewShelf(shelf);
                return true;
            }
        }

        public static List<EShelf> GetAll()
        {
            return DALShelf.GetAll();
        }

        public static EShelf GetIdOnly(int shelfID)
        {
            return DALShelf.GetIdOnly(shelfID);
        }

        public static bool Update(EShelf shelf)
        {
            DALShelf.Update(shelf);
            return true;
        }

        public static bool Delete(EShelf shelf)
        {
            DALShelf.Delete(shelf);
            return true;
        }
    }
}
