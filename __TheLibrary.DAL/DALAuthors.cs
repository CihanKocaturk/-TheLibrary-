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
    public class DALAuthors
    {
        public static void InsertNewAuthor(EAuthors author)
        {
            SqlCommand cmd = new SqlCommand("spAuthor_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
            cmd.Parameters.AddWithValue("@LastName", author.LastName);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EAuthors> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spAuthors_GetAll", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EAuthors> aliste = new List<EAuthors>();
            while (dr.Read())
            {
                EAuthors a = new EAuthors();
                a.ID = Convert.ToInt32(dr["ID"]);
                a.FirstName = dr["FirstName"].ToString();
                a.LastName = dr["LastName"].ToString();
                a.FullName = a.FirstName + " " + a.LastName;              
                aliste.Add(a);
            }
            dr.Close();
            Baglanti.conn.Close();
            return aliste;
        }

        public static EAuthors GetIdOnly(int authorId)
        {
            SqlCommand cmd = new SqlCommand("spAuthors_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AuthorID", authorId);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EAuthors author = new EAuthors();
            while (dr.Read())
            {
                author.ID = Convert.ToInt32(dr["ID"]);
                author.FirstName = dr["FirstName"].ToString();
                author.LastName = dr["LastName"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return author;
        }

        public static List<EAuthors> GetAuthorNames()
        {
            SqlCommand cmd = new SqlCommand("spAuthors_GetNames", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EAuthors> aliste = new List<EAuthors>();
            while (dr.Read())
            {
                EAuthors a = new EAuthors();
                a.ID = Convert.ToInt32(dr["ID"]);
                a.FullName = dr["FullName"].ToString();
                aliste.Add(a);
            }
            dr.Close();
            Baglanti.conn.Close();
            return aliste;
        }

        public static void Update(EAuthors author)
        {
            SqlCommand cmd = new SqlCommand("spAuthor_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
            cmd.Parameters.AddWithValue("@LastName", author.LastName);
            cmd.Parameters.AddWithValue("@AuthorID", author.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EAuthors author)
        {
            SqlCommand cmd = new SqlCommand("spAuthor_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("authorID", author.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
