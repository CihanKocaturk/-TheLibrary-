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
    public class DALMembers
    {
        public static void InsertNewMember(EMembers member)
        {
            SqlCommand cmd = new SqlCommand("spMember_Insert", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCNo", member.TCNo);
            cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            cmd.Parameters.AddWithValue("@LastName", member.LastName);
            cmd.Parameters.AddWithValue("Phone", member.Phone);
            cmd.Parameters.AddWithValue("Adres", member.Address);

            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static List<EMembers> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spMembers_GetAll", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMembers> eliste = new List<EMembers>();
            while (dr.Read())
            {
                EMembers e = new EMembers();
                e.ID = Convert.ToInt32(dr["ID"]);
                e.TCNo = dr["TC No"].ToString();
                e.FirstName = dr["FirstName"].ToString();
                e.LastName = dr["LastName"].ToString();
                e.Phone = dr["Phone"].ToString();
                e.Address = dr["Adres"].ToString();
                eliste.Add(e);
            }
            dr.Close();
            Baglanti.conn.Close();
            return eliste;
        }

        public static EMembers GetIdOnly(int memberID)
        {
            SqlCommand cmd = new SqlCommand("spMembers_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MemberID", memberID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EMembers member = new EMembers();
            while (dr.Read())
            {
                member.ID = Convert.ToInt32(dr["ID"]);
                member.TCNo = dr["TC No"].ToString();
                member.FirstName = dr["FirstName"].ToString();
                member.LastName = dr["LastName"].ToString();
                member.Phone = dr["Phone"].ToString();
                member.Address = dr["Adres"].ToString();
            }
            dr.Close();
            Baglanti.conn.Close();
            return member;
        }

        public static List<EMembers> GetMemberNames()
        {
            SqlCommand cmd = new SqlCommand("spMembers_GetNames", Baglanti.conn);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMembers> mliste = new List<EMembers>();
            while (dr.Read())
            {
                EMembers m = new EMembers();
                m.ID = Convert.ToInt32(dr["ID"]);               
                m.FullName = dr["FullName"].ToString();
                mliste.Add(m);
            }
            dr.Close();
            Baglanti.conn.Close();
            return mliste;
        }

        public static void Update(EMembers member)
        {
            SqlCommand cmd = new SqlCommand("spMembers_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCNo", member.TCNo);
            cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            cmd.Parameters.AddWithValue("@LastName", member.LastName);
            cmd.Parameters.AddWithValue("Phone", member.Phone);
            cmd.Parameters.AddWithValue("Adres", member.Address);
            cmd.Parameters.AddWithValue("@MemberID", member.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EMembers member)
        {
            SqlCommand cmd = new SqlCommand("spMembers_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("memberID", member.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
