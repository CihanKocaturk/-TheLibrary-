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
    public partial class Yayınevleri_Listesi : Form
    {
        public Yayınevleri_Listesi()
        {
            InitializeComponent();
        }

        private void Yayınevleri_Listesi_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = BLLPublisher.GetAll();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
        }
    }
}
