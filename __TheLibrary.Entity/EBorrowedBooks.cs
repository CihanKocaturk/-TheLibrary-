using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.Entity
{
    public class EBorrowedBooks
    {
        public EBorrowedBooks()
        {
            this.Employee = new EEmployees();
            this.Member = new EMembers();
            this.Book = new EBooks();
        }

        public int ID { get; set; }
        public EEmployees Employee { get; set; }
        public EMembers Member { get; set; }
        public EBooks Book { get; set; }
        public DateTime DateOfBorrow { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public bool IsReturned { get; set; }

        public string employeeFullName
        {
            get
            {
                return Employee.FullName;
            }
        }
        public string memberFullName
        {
            get
            {
                return Member.FullName;
            }
        }
        public string bookISBNNO
        {
            get
            {
                return Book.ISBNNO;
            }
        }
        public string bookName
        {
            get
            {
                return Book.Name;
            }
        }
    }
}
