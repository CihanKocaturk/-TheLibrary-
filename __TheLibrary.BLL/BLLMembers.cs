using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
     public class BLLMembers
    {
        public static bool InsertNewMember(EMembers member)
        {
            if (member.TCNo == "" || member.FirstName == "" || member.LastName == "" || member.Phone == "")
            {
                return false;
            }
            else
            {
                DALMembers.InsertNewMember(member);
                return true;
            }
        }

        public static List<EMembers> GetAll()
        {
            return DALMembers.GetAll();
        }

        public static EMembers GetIdOnly(int memberID)
        {
            return DALMembers.GetIdOnly(memberID);
        }

        public static List<EMembers> GetMemberNames()
        {
            return DALMembers.GetMemberNames();
        }

        public static bool Update(EMembers member)
        {
            DALMembers.Update(member);
            return true;
        }

        public static bool Delete(EMembers member)
        {
            DALMembers.Delete(member);
            return true;
        }
    }
}
