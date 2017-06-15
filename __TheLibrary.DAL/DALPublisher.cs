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
    public class DALPublisher
    {
        public static void InsertNewPublisher(EPublisher publisher)
        {
            SqlCommand cmd = new SqlCommand("spPublisher_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", publisher.Name);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EPublisher> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spPublisher_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EPublisher> pliste = new List<EPublisher>();
            while (dr.Read())
            {
                EPublisher p = new EPublisher();
                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = dr["Name"].ToString();
                pliste.Add(p);
            }
            dr.Close();
            Baglanti.conn.Close();
            return pliste;
        }

        public static EPublisher GetIdOnly(int publisherID)
        {
            SqlCommand cmd = new SqlCommand("spPublisher_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PublisherID", publisherID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EPublisher publisher = new EPublisher();
            while (dr.Read())
            {
                publisher.ID = Convert.ToInt32(dr["ID"]);
                publisher.Name = dr["Name"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return publisher;
        }

        public static void Update(EPublisher publisher)
        {
            SqlCommand cmd = new SqlCommand("spPublisher_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", publisher.Name);
            cmd.Parameters.AddWithValue("@PublisherID", publisher.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EPublisher publisher)
        {
            SqlCommand cmd = new SqlCommand("spPublisher_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("publisherID", publisher.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
