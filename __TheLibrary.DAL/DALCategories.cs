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
    public class DALCategories
    {
        public static void InsertNewCategory(ECategories category)
        {
            SqlCommand cmd = new SqlCommand("spCategories_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Description", category.Description);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<ECategories> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spCategories_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<ECategories> cliste = new List<ECategories>();
            while (dr.Read())
            {
                ECategories c = new ECategories();
                c.ID = Convert.ToInt32(dr["ID"]);
                c.Name = dr["Name"].ToString();
                c.Description = dr["Description"].ToString();
                cliste.Add(c);
            }
            dr.Close();
            Baglanti.conn.Close();
            return cliste;
        }

        public static ECategories GetIdOnly(int categoryID)
        {
            SqlCommand cmd = new SqlCommand("spCategories_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryID", categoryID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            ECategories category = new ECategories();
            while (dr.Read())
            {
                category.ID = Convert.ToInt32(dr["ID"]);
                category.Name = dr["Name"].ToString();
                category.Description = dr["Description"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return category;
        }

        public static void Update(ECategories category)
        {
            SqlCommand cmd = new SqlCommand("spCategories_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Description", category.Description);
            cmd.Parameters.AddWithValue("@categoryID", category.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(ECategories category)
        {
            SqlCommand cmd = new SqlCommand("spCategories_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("categoryID", category.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
