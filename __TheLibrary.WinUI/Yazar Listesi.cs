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
    public partial class Yazar_Listesi : Form
    {
        public Yazar_Listesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            foreach (EAuthors item in BLLAuthors.GetAll())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.FirstName;
                lvi.SubItems.Add(item.LastName).ToString();
                lvi.Tag = item.ID;
                lvYazar.Items.Add(lvi);
            }
        }

        private void Yazar_Listesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
