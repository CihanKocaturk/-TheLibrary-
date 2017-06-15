using __TheLibrary.DAL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.BLL
{
    public class BLLEmployees
    {
        public static bool InsertNewEmployee(EEmployees employee)
        {
            if (employee.TCNo == "" || employee.FirstName == "" || employee.LastName == "" || employee.Phone == "")
            {
                return false;
            }
            else
            {
                DALEmployees.InsertNewEmployee(employee);
                return true;
            }
        }

        public static List<EEmployees> GetAll()
        {
            return DALEmployees.GetAll();
        }

        public static EEmployees GetIdOnly(int employeeID)
        {
            return DALEmployees.GetIdOnly(employeeID);
        }

        public static List<EEmployees> GetEmployeeNames()
        {
            return DALEmployees.GetMemberNames();
        }

        public static bool Update(EEmployees employee)
        {
            DALEmployees.Update(employee);
            return true;
        }

        public static bool Delete(EEmployees employee)
        {
            DALEmployees.Delete(employee);
            return true;
        }
    }
}
