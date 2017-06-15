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
    public class DALBorrowedBooks
    {
        public static void InsertBorrowedBook(EBorrowedBooks borrowedBook)
        {
            SqlCommand cmd = new SqlCommand("spBorrowedBooks_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", borrowedBook.Book.ID);
            cmd.Parameters.AddWithValue("@EmployeeID", borrowedBook.Employee.ID);
            cmd.Parameters.AddWithValue("@MemberID", borrowedBook.Member.ID);
            cmd.Parameters.AddWithValue("@ExpireDate", borrowedBook.ExpireDate);
            cmd.Parameters.AddWithValue("@DateOfBorrow", borrowedBook.DateOfBorrow); 

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EBorrowedBooks> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spBorrowedBooks_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EBorrowedBooks> bliste = new List<EBorrowedBooks>();
            while (dr.Read())
            {
                EBorrowedBooks b = new EBorrowedBooks();
                b.Employee = new EEmployees();
                b.Member = new EMembers();
                b.Book = new EBooks();
                b.ID = Convert.ToInt32(dr["ID"]);
                b.Book.Name = dr["Name"].ToString();
                b.Employee.ID = Convert.ToInt32(dr["EmployeeID"]);
                b.Employee.FullName = dr["EmployeeName"].ToString();
                b.Member.ID = Convert.ToInt32(dr["MemberID"]);
                b.Member.FullName = dr["MemberName"].ToString();
                b.DateOfBorrow = Convert.ToDateTime(dr["DateOfBorrow"]);
                b.ExpireDate = Convert.ToDateTime(dr["ExpireDate"]);
                b.Book.ID = Convert.ToInt32(dr["BookID"]);
                b.Book.ISBNNO = dr["ISBN No"].ToString();
                b.IsReturned = Convert.ToBoolean(dr["IsReturned"]);
                if (dr["DateOfReturn"] == DBNull.Value)
                    b.DateOfReturn = null;
                else
                    b.DateOfReturn = Convert.ToDateTime(dr["DateOfReturn"]);
                bliste.Add(b);
            }
            dr.Close();
            Baglanti.conn.Close();
            return bliste;
        }

        public static EBorrowedBooks GetIdOnly(int borrowedBookID)
        {
            SqlCommand cmd = new SqlCommand("spBorrowedBooks_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BorrowedBookID", borrowedBookID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EBorrowedBooks b = new EBorrowedBooks();
            while (dr.Read())
            {
                b.Employee = new EEmployees();
                b.Member = new EMembers();
                b.Book = new EBooks();
                b.ID = Convert.ToInt32(dr["ID"]);
                b.Employee.ID = Convert.ToInt32(dr["EmployeeID"]);
                b.Member.ID = Convert.ToInt32(dr["MemberID"]);
                b.DateOfBorrow = Convert.ToDateTime(dr["DateOfBorrow"]);
                b.ExpireDate = Convert.ToDateTime(dr["ExpireDate"]);
                b.Book.ID = Convert.ToInt32(dr["BookID"]);
            }
            dr.Close();
            Baglanti.conn.Close();
            return b;
        }

        public static void Update(EBorrowedBooks borrowedBook)
        {
            SqlCommand cmd = new SqlCommand("spBorrowedBooks_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DateOfReturn", borrowedBook.DateOfReturn);
            cmd.Parameters.AddWithValue("@BorrowedBookID", borrowedBook.ID);
            cmd.Parameters.AddWithValue("@IsReturned", borrowedBook.IsReturned);
            cmd.Parameters.AddWithValue("@BookID", borrowedBook.Book.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
