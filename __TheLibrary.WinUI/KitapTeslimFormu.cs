using __TheLibrary.BLL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __TheLibrary.WinUI
{
    public partial class KitapTeslimFormu : Form
    {
        public KitapTeslimFormu()
        {
            InitializeComponent();
        }

        private void KitapTeslimFormu_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<EBorrowedBooks> kiralist = BLLBorrowedBooks.GetAll();
            kiralist = (from k in kiralist
                        where k.IsReturned == true
                        select k).ToList<EBorrowedBooks>();
            dataGridView1.DataSource = kiralist;
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            EBorrowedBooks returnBook = new EBorrowedBooks();
            returnBook = (EBorrowedBooks)dataGridView1.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("'" + returnBook.bookName + "'" + " " + "isimli kitabı teslim almak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                returnBook.IsReturned = false;
                returnBook.DateOfReturn = DateTime.Now;
                bool sonuc = BLLBorrowedBooks.Update(returnBook);
                if (sonuc)
                {
                    MessageBox.Show("Harika! Kitap Teslim Alındı!");
                    txtIsbnNo.Clear();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu!");
                }
            }
                
            List<EBorrowedBooks> kiralist = BLLBorrowedBooks.GetAll();
            kiralist = (from k in kiralist
                        where k.IsReturned == true
                        select k).ToList<EBorrowedBooks>();
            dataGridView1.DataSource = kiralist;
        }

        private void txtIsbnNo_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtIsbnNo.Text;

            List<EBorrowedBooks> kiralamaList = BLLBorrowedBooks.GetAll();

            kiralamaList = (from l in kiralamaList
                            where l.Book.ISBNNO.Trim().ToLower().Contains(searchText.Trim().ToLower())
                            && l.IsReturned == true
                            select l).ToList<EBorrowedBooks>();

            dataGridView1.DataSource = kiralamaList;
        }
    }
}
