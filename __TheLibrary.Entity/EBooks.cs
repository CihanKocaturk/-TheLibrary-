using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.Entity
{
    public class EBooks
    {
        public EBooks()
        {
            this.Category = new ECategories();
            this.Publisher = new EPublisher();
            this.Shelf = new EShelf();
            this.Author = new EAuthors();
        }
            
        

        public int ID { get; set; }
        public string Name { get; set; }
        public EAuthors Author  { get; set; }
        public string ISBNNO { get; set; }
        public DateTime DateOfPublish { get; set; }
        public EShelf Shelf { get; set; }
        public ECategories Category { get; set; }
        public EPublisher Publisher { get; set; }
        public bool Durum { get; set; }
        public bool IsReturned { get; set; }
        public string categoryName
        {
            get
            {
                return Category.Name;
            }
        }
        public string publisherName
        {
            get
            {
                return Publisher.Name;
            }
        }
        public string authorFirstName
        {
            get
            {
                return Author.FirstName;
            }
        }
        public string authorLastName
        {
            get
            {
                return Author.LastName;
            }
        }
        public string shelfNo
        {
            get
            {
                return Shelf.ShelfNo;
            }
        }

    }
}
