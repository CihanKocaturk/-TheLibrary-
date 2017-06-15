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
    public partial class Kitap_Türleri : Form
    {
        public Kitap_Türleri()
        {
            InitializeComponent();
        }

        private void Kitap_Türleri_Load(object sender, EventArgs e)
        {
            lstTurler.DataSource = BLLCategories.GetAll();
            lstTurler.DisplayMember = "Name";
            lstTurler.ValueMember = "ID";
        }
    }
}
