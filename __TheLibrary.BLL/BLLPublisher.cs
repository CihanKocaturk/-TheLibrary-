using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLPublisher
    {
        public static bool InsertNewPublisher(EPublisher publisher)
        {
            if (publisher.Name == "")
            {
                return false;
            }
            else
            {
                DALPublisher.InsertNewPublisher(publisher);
                return true;
            }
        }

        public static List<EPublisher> GetAll()
        {
            return DALPublisher.GetAll();
        }

        public static EPublisher GetIdOnly(int publisherID)
        {
            return DALPublisher.GetIdOnly(publisherID);
        }

        public static bool Update(EPublisher publisher)
        {
            DALPublisher.Update(publisher);
            return true;
        }

        public static bool Delete(EPublisher publisher)
        {
            DALPublisher.Delete(publisher);
            return true;
        }
    }
}
