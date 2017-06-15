using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.DAL
{
    public class DALEmployees
    {
        public static void InsertNewEmployee(EEmployees employee)
        {
            SqlCommand cmd = new SqlCommand("spEmployees_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCNo", employee.TCNo);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("Phone", employee.Phone);
            cmd.Parameters.AddWithValue("Adres", employee.Address);
            cmd.Parameters.AddWithValue("UserName", employee.UserName);
            cmd.Parameters.AddWithValue("Password", employee.Password);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EEmployees> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spEmployees_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EEmployees> eliste = new List<EEmployees>();
            while (dr.Read())
            {
                EEmployees e = new EEmployees();
                e.ID = Convert.ToInt32(dr["ID"]);
                e.TCNo = dr["TC No"].ToString();
                e.FirstName = dr["FirstName"].ToString();
                e.LastName = dr["LastName"].ToString();
                e.FullName = e.FirstName + " " + e.LastName; 
                e.Phone = dr["Phone"].ToString();
                e.Address = dr["Adres"].ToString();
                e.UserName = dr["UserName"].ToString();
                e.Password = dr["Password"].ToString();
                eliste.Add(e);
            }
            dr.Close();
            Baglanti.conn.Close();
            return eliste;
        }

        public static EEmployees GetIdOnly(int employeeID)
        {
            SqlCommand cmd = new SqlCommand("spEmployees_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EEmployees employee = new EEmployees();
            while (dr.Read())
            {
                employee.ID = Convert.ToInt32(dr["ID"]);
                employee.TCNo = dr["TC No"].ToString();
                employee.FirstName = dr["FirstName"].ToString();
                employee.LastName = dr["LastName"].ToString();
                employee.Phone = dr["Phone"].ToString();
                employee.Address = dr["Adres"].ToString();
                employee.UserName = dr["UserName"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return employee;
        }

        public static List<EEmployees> GetMemberNames()
        {
            SqlCommand cmd = new SqlCommand("spEmployees_GetNames", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EEmployees> mliste = new List<EEmployees>();
            while (dr.Read())
            {
                EEmployees e = new EEmployees();
                e.ID = Convert.ToInt32(dr["ID"]);
                e.FullName = dr["FullName"].ToString();
                mliste.Add(e);
            }
            dr.Close();
            Baglanti.conn.Close();
            return mliste;
        }

        public static void Update(EEmployees employee)
        {
            SqlCommand cmd = new SqlCommand("spEmployees_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCNo", employee.TCNo);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("Phone", employee.Phone);
            cmd.Parameters.AddWithValue("Adres", employee.Address);
            cmd.Parameters.AddWithValue("@EmployeeID", employee.ID);
            cmd.Parameters.AddWithValue("UserName", employee.UserName);
            cmd.Parameters.AddWithValue("Password", employee.Password);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EEmployees employee)
        {
            SqlCommand cmd = new SqlCommand("spEmployees_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("employeeID", employee.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
