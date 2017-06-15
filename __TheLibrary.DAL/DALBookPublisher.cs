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
    public class DALBookPublisher
    {
        public static void InsertNewBookPublisher(EBookPublisher publisher)
        {
            SqlCommand cmd = new SqlCommand("spBookPublisher_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PublisherID", publisher.PublisherID);
            cmd.Parameters.AddWithValue("@BookID", publisher.BookID);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
