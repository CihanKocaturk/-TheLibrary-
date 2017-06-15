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
    public class DALShelf
    {
        public static void InsertNewShelf(EShelf shelf)
        {
            SqlCommand cmd = new SqlCommand("spShelf_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShelfNo", shelf.ShelfNo);
            cmd.Parameters.AddWithValue("@CategoryID", shelf.Category.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EShelf> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spShelf_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EShelf> sliste = new List<EShelf>();
            while (dr.Read())
            {
                EShelf e = new EShelf();
                e.Category = new ECategories();
                e.ID = Convert.ToInt32(dr["ID"]);
                e.ShelfNo = dr["ShelfNo"].ToString();
                e.Category.Name = dr["Name"].ToString();
                sliste.Add(e);
            }
            dr.Close();
            Baglanti.conn.Close();
            return sliste;
        }

        public static EShelf GetIdOnly(int shelfID)
        {
            SqlCommand cmd = new SqlCommand("spShelf_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShelfID", shelfID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EShelf shelf = new EShelf();
            shelf.Category = new ECategories();
            while (dr.Read())
            {
                shelf.ID = Convert.ToInt32(dr["ID"]);
                shelf.ShelfNo = dr["ShelfNo"].ToString();
                shelf.Category.Name = dr["Name"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return shelf;
        }

        public static void Update(EShelf shelf)
        {
            SqlCommand cmd = new SqlCommand("spShelf_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShelfNo", shelf.ShelfNo);
            cmd.Parameters.AddWithValue("@CategoryID", shelf.Category.ID);
            cmd.Parameters.AddWithValue("@ShelfID", shelf.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EShelf shelf)
        {
            SqlCommand cmd = new SqlCommand("spShelf_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("shelfID", shelf.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
