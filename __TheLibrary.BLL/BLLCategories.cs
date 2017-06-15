using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLCategories
    {
        public static bool InsertNewCategory(ECategories category)
        {
            if (category.Name == "")
            {
                return false;
            }
            else
            {
                DALCategories.InsertNewCategory(category);
                return true;
            }
        }

        public static List<ECategories> GetAll()
        {
            return DALCategories.GetAll();
        }

        public static ECategories GetIdOnly(int categoryID)
        {
            return DALCategories.GetIdOnly(categoryID);
        }

        public static bool Update(ECategories category)
        {
            DALCategories.Update(category);
            return true;
        }
        public static bool Delete(ECategories category)
        {
            DALCategories.Delete(category);
            return true;
        }

    }
}
