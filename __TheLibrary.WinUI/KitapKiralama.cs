using __TheLibrary.BLL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __TheLibrary.WinUI
{
    public partial class KitapKiralama : Form
    {
        public KitapKiralama()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            List<EBooks> bookList = BLLBooks.GetBookNames();
            if (bookList != null && bookList.Count > 0)
            {
                bookList = (from l in bookList
                            where l.IsReturned == false
                            select l).ToList<EBooks>();
            }
            cmbVerilenKitap.DataSource = bookList;
            cmbVerilenKitap.DisplayMember = "Name";
            cmbVerilenKitap.ValueMember = "ID";

            cmbMembers.DataSource = BLLMembers.GetMemberNames();
            cmbMembers.DisplayMember = "FullName";
            cmbMembers.ValueMember = "ID";

            cmbEmployees.DataSource = BLLEmployees.GetEmployeeNames();
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "ID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex != -1 & cmbMembers.SelectedIndex != -1 & cmbVerilenKitap.SelectedIndex != -1)
            {
                EBorrowedBooks borrowedBook = new EBorrowedBooks();
                borrowedBook.Book = new EBooks();
                borrowedBook.Member = new EMembers();
                borrowedBook.Employee = new EEmployees();
                borrowedBook.Book.ID = Convert.ToInt32(cmbVerilenKitap.SelectedValue);
                borrowedBook.Employee.ID = Convert.ToInt32(cmbEmployees.SelectedValue);
                borrowedBook.Member.ID = Convert.ToInt32(cmbMembers.SelectedValue);
                borrowedBook.DateOfBorrow = DateTime.Now;
                borrowedBook.ExpireDate = dtpExpireDate.Value;


                if (borrowedBook.DateOfBorrow <= borrowedBook.ExpireDate)
                {
                    if (BLLBorrowedBooks.InsertBorrowedBook(borrowedBook))
                    {

                        MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşmiştir.");
                        List<EBooks> bookList = BLLBooks.GetBookNames();
                        if (bookList != null && bookList.Count > 0)
                        {
                            bookList = (from l in bookList
                                        where l.IsReturned == false
                                        select l).ToList<EBooks>();
                        }
                        cmbVerilenKitap.DataSource = bookList;
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Kitap Teslim Tarihi, alınan tarihten eski olamaz!");
                }

                cmbEmployees.SelectedIndex = -1;
                cmbMembers.SelectedIndex = -1;
                cmbVerilenKitap.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
            }
        }
    }
}
