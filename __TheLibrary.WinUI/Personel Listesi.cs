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
    public partial class Personel_Listesi : Form
    {
        public Personel_Listesi()
        {
            InitializeComponent();
        }

        private void Personel_Listesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLEmployees.GetAll();

        }
    }
}
