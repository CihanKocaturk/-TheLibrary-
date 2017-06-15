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
    public partial class GelismisArama : Form
    {
        public GelismisArama()
        {
            InitializeComponent();
        }

        private void GelismisArama_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLBooks.GetAll();

            cmbYazar.DataSource = BLLAuthors.GetAll();
            cmbYazar.DisplayMember = "FullName";
            cmbYazar.ValueMember = "ID";

            cmbTur.DataSource = BLLCategories.GetAll();
            cmbTur.DisplayMember = "Name";
            cmbTur.ValueMember = "ID";

            cmbRaf.DataSource = BLLShelf.GetAll();
            cmbRaf.DisplayMember = "ShelfNo";
            cmbRaf.ValueMember = "ID";

            cmbYayinevi.DataSource = BLLPublisher.GetAll();
            cmbYayinevi.DisplayMember = "Name";
            cmbYayinevi.ValueMember = "ID";

            cmbRaf.Enabled = false;
            cmbTur.Enabled = false;
            cmbYayinevi.Enabled = false;
            cmbYazar.Enabled = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<EBooks> bookList = BLLBooks.GetAll();
            int selectedAuthorID = int.Parse(cmbYazar.SelectedValue.ToString());
            int selectedShelfID = int.Parse(cmbRaf.SelectedValue.ToString());
            int selectedCategoryID = int.Parse(cmbTur.SelectedValue.ToString());
            int selectedPublisherID = int.Parse(cmbYayinevi.SelectedValue.ToString());


            if (bookList != null && bookList.Count > 0)
            {
                if (chbYazar.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Author.ID == selectedAuthorID
                                select l).ToList<EBooks>();
                }

                if (chbYayinevi.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Publisher.ID == selectedPublisherID
                                select l).ToList<EBooks>();
                }

                if (chbTur.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Category.ID == selectedCategoryID
                                select l).ToList<EBooks>();
                }

                if (chbRaf.Checked == true)
                {
                    bookList = (from l in bookList
                                where l.Shelf.ID == selectedShelfID
                                select l).ToList<EBooks>();
                }

                if (bookList.Count > 0)
                {
                    dataGridView1.DataSource = bookList;
                }
                else
                {
                    MessageBox.Show("Aradığınız kriterlerde kitap bulunmamaktadır!");
                    dataGridView1.DataSource = bookList;                    
                }
            }
            txtISBNNo.Clear();
            txtKitap.Clear();
            txtYazar.Clear();
        }

        private void chbTur_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTur.Checked == true)
            {
                cmbTur.Enabled = true;
            }
            else
            {
                cmbTur.Enabled = false;

            }
        }

        private void chbRaf_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRaf.Checked == true)
            {
                cmbRaf.Enabled = true;
            }
            else
            {
                cmbRaf.Enabled = false;

            }
        }

        private void chbYazar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbYazar.Checked == true)
            {
                cmbYazar.Enabled = true;
            }
            else
            {
                cmbYazar.Enabled = false;

            }
        }

        private void chbYayinevi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbYayinevi.Checked == true)
            {
                cmbYayinevi.Enabled = true;
            }
            else
            {
                cmbYayinevi.Enabled = false;

            }
        }

        private void txtKitap_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtKitap.Text;

            List<EBooks> booklist = BLLBooks.GetAll();

            booklist = (from l in booklist
                            where l.Name.Trim().ToLower().Contains(searchText.Trim().ToLower())
                            select l).ToList<EBooks>();

            dataGridView1.DataSource = booklist;
            txtISBNNo.Clear();
            txtYazar.Clear();
        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtYazar.Text;

            List<EBooks> booklist = BLLBooks.GetAll();

            booklist = (from l in booklist
                        where l.Author.FullName.Trim().ToLower().Contains(searchText.Trim().ToLower())
                        select l).ToList<EBooks>();

            dataGridView1.DataSource = booklist;
            txtKitap.Clear();
            txtISBNNo.Clear();
        }

        private void txtISBNNo_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtISBNNo.Text;

            List<EBooks> booklist = BLLBooks.GetAll();

            booklist = (from l in booklist
                        where l.ISBNNO.Trim().ToLower().Contains(searchText.Trim().ToLower())
                        select l).ToList<EBooks>();

            dataGridView1.DataSource = booklist;
            txtKitap.Clear();
            txtYazar.Clear();
        }
    }
}
