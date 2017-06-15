using __TheLibrary.Entity;
using __TheLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLBookPublisher
    {
        public static bool InsertNewBookPublisher(EBookPublisher bookpublisher)
        {
            if (bookpublisher.PublisherID < 1)
            {
                return false;
            }
            else
            {
                DALBookPublisher.InsertNewBookPublisher(bookpublisher);
                return true;
            }
        }
    }
}
