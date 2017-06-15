using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLAuthors
    {
        public static bool InsertNewAuthor(EAuthors author)
        {
            if (author.FirstName == "" || author.LastName == "")
            {
                return false;
            }
            else
            {
                DALAuthors.InsertNewAuthor(author);
                return true;
            }
        }

        public static List<EAuthors> GetAll()
        {
            List<EAuthors> authList = new List<EAuthors>();
            authList = DALAuthors.GetAll();
            if (authList != null)
                return authList;
            else
                return new List<EAuthors>();
        }

        public static EAuthors GetIdOnly(int authorID)
        {
            return DALAuthors.GetIdOnly(authorID);
        }

        public static List<EAuthors> GetAuthorNames()
        {

            //List<EAuthors> list = new List<EAuthors>();

            //list = DALAuthors.GetAuthorNames();

            //list = (from l in list
            //        where l.FirstName.Contains("Ali")
            //        select l).ToList<EAuthors>();

            ////if (DALAuthors.GetAuthorNames()!= null)
            ////{

            ////}
            return DALAuthors.GetAuthorNames();
        }

        public static bool Update(EAuthors author)
        {
            DALAuthors.Update(author);
            return true;
        }

        public static bool Delete(EAuthors author)
        {
            DALAuthors.Delete(author);
            return true;
        }
    }
}
