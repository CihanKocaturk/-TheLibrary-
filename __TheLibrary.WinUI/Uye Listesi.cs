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
    public partial class Uye_Listesi : Form
    {
        public Uye_Listesi()
        {
            InitializeComponent();
        }

        private void Uye_Listesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLMembers.GetAll();
        }
    }
}
