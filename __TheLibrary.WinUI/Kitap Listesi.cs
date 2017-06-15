using __TheLibrary.BLL;
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
    public partial class Kitap_Listesi : Form
    {
        public Kitap_Listesi()
        {
            InitializeComponent();
        }

        private void Kitap_Listesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLBooks.GetAll();
        }
    }
}
