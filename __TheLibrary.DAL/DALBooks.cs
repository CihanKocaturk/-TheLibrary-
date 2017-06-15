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
    public class DALBooks
    {
        private const string SP_BOOKS_INSERT = "spBooks_Insert";

        public static int InsertNewBook(EBooks book)
        {
            SqlCommand cmd = new SqlCommand(SP_BOOKS_INSERT, Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", book.Name);
            cmd.Parameters.AddWithValue("@AuthorID", book.Author.ID);
            cmd.Parameters.AddWithValue("@DateOfPublish", book.DateOfPublish);
            cmd.Parameters.AddWithValue("@ISBNNO", book.ISBNNO);
            cmd.Parameters.AddWithValue("@ShelfID", book.Shelf.ID);

            Baglanti.conn.Open();
            int insertedID = (int)cmd.ExecuteScalar();
            Baglanti.conn.Close();

            return insertedID;
        }

        public static List<EBooks> GetAll()
        {
            SqlCommand cmd = new SqlCommand("spBooks_GetAll", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EBooks> rliste = new List<EBooks>();
            while (dr.Read())
            {
                EBooks b = new EBooks();
                b.ID = Convert.ToInt32(dr["ID"]);
                b.Name = dr["Name"].ToString();
                b.Author.ID = Convert.ToInt32(dr["AuthorID"]);
                b.Author.FirstName = dr["FirstName"].ToString();
                b.Author.LastName = dr["LastName"].ToString();
                b.Author.FullName = b.Author.FirstName + " " + b.Author.LastName;
                b.DateOfPublish = Convert.ToDateTime(dr["DateOfPublish"]);
                b.ISBNNO = dr["ISBN No"].ToString();
                b.Shelf.ShelfNo = dr["ShelfNo"].ToString();
                b.Shelf.ID = Convert.ToInt32(dr["ShelfID"]);
                b.Publisher.Name = dr["PublisherName"].ToString();
                b.Publisher.ID = Convert.ToInt32(dr["PublisherID"]);
                b.Category.Name = dr["CategoryName"].ToString();
                b.Category.ID = Convert.ToInt32(dr["CategoryID"]);
                b.IsReturned = Convert.ToBoolean(dr["IsReturned"]);
                rliste.Add(b);
            }
            dr.Close();
            Baglanti.conn.Close();
            return rliste;
        }

        public static EBooks GetIdOnly(int bookID)
        {
            SqlCommand cmd = new SqlCommand("spBooks_GetIdOnly", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", bookID);
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EBooks book = new EBooks();
            book.Author = new EAuthors();
            book.Shelf = new EShelf();
            book.Category = new ECategories();
            book.Publisher = new EPublisher();
            
            while (dr.Read())
            {
                book.ID = Convert.ToInt32(dr["ID"]);
                book.Name = dr["Name"].ToString();
                book.Author.ID = Convert.ToInt32(dr["AuthorID"]);
                book.Author.FirstName = dr["FirstName"].ToString();
                book.Author.LastName = dr["LastName"].ToString();
                book.Author.FullName = book.Author.FirstName + " " + book.Author.LastName;
                book.DateOfPublish = Convert.ToDateTime(dr["DateOfPublish"]);
                book.ISBNNO = dr["ISBN No"].ToString();
                book.Shelf.ID = Convert.ToInt32(dr["ShelfID"]);
                book.Shelf.ShelfNo = dr["ShelfNo"].ToString();
                book.Publisher.ID = Convert.ToInt32(dr["PublisherID"]);
                book.Publisher.Name = dr["PublisherName"].ToString();
                book.Category.Name = dr["CategoryName"].ToString();
                
            }
            dr.Close();
            Baglanti.conn.Close();
            return book;
        }

        public static List<EBooks> GetBookNames()
        {
            SqlCommand cmd = new SqlCommand("spBooks_GetOnlyBooks", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EBooks> rliste = new List<EBooks>();
            while (dr.Read())
            {
                EBooks b = new EBooks();
                b.ID = Convert.ToInt32(dr["ID"]);
                b.Name = dr["Name"].ToString();
                b.IsReturned = Convert.ToBoolean(dr["IsReturned"]);
                rliste.Add(b);
            }
            dr.Close();
            Baglanti.conn.Close();
            return rliste;
        }

        public static void Update(EBooks ubook)
        {
            SqlCommand cmd = new SqlCommand("spBooks_Update", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", ubook.Name);
            cmd.Parameters.AddWithValue("@AuthorID", ubook.Author.ID);
            cmd.Parameters.AddWithValue("@DateOfPublish", ubook.DateOfPublish);
            cmd.Parameters.AddWithValue("@ISBNNO", ubook.ISBNNO);
            cmd.Parameters.AddWithValue("@ShelfID", ubook.Shelf.ID);
            cmd.Parameters.AddWithValue("@bookID", ubook.ID);
            cmd.Parameters.AddWithValue("@CategoryID", ubook.Category.ID);
            cmd.Parameters.AddWithValue("@PublisherID", ubook.Publisher.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }

        public static void Delete(EBooks book)
        {
            SqlCommand cmd = new SqlCommand("spBooks_Delete", Baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("bookID", book.ID);
            Baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            Baglanti.conn.Close();
        }
    }
}
