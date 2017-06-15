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
    public class DALBookCategory
    {
        public static void InsertNewBooksCategory(EBookCategory category)
        {
            SqlCommand cmd = new SqlCommand("spBookCategory_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            cmd.Parameters.AddWithValue("@BookID", category.BookID);
            
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
