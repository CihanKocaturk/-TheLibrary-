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
    public partial class Raflar : Form
    {
        public Raflar()
        {
            InitializeComponent();
        }

        void Listele()
        {
            foreach (EShelf item in BLLShelf.GetAll())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ShelfNo;
                lvi.SubItems.Add(item.Category.Name).ToString();                
                lvi.Tag = item.ID;
                lvRehber.Items.Add(lvi);
            }
        }

        private void Raflar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
