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
    public partial class KiralananKitaplar : Form
    {
        public KiralananKitaplar()
        {
            InitializeComponent();
        }

        private void KiralananKitaplar_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLBorrowedBooks.GetAll();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EBorrowedBooks borrowedBook = ((List<EBorrowedBooks>)(dataGridView1.DataSource))[e.RowIndex];

            if (borrowedBook.DateOfReturn < borrowedBook.ExpireDate && borrowedBook.DateOfReturn != null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            else if (borrowedBook.ExpireDate == DateTime.Now && borrowedBook.DateOfReturn == null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            else if (borrowedBook.ExpireDate < borrowedBook.DateOfReturn && borrowedBook.DateOfReturn != null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Purple;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            else if (borrowedBook.ExpireDate <= DateTime.Now && borrowedBook.DateOfReturn == null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            else if (borrowedBook.ExpireDate > DateTime.Now && borrowedBook.DateOfReturn == null)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
