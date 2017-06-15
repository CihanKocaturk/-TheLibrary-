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
    public partial class Yeni_Üye_Kayıt : Form
    {
        public Yeni_Üye_Kayıt()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                txtCepNo.Clear();
            }
        }

        private void Yeni_Üye_Kayıt_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLMembers.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) & !string.IsNullOrEmpty(txtSoyad.Text) & !string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text))
            {
                if (txtTCNo.Text.Length == 11)
                {
                    List<EMembers> memberList = BLLMembers.GetAll();
                    memberList = (from l in memberList
                                  where l.TCNo.Trim().ToLower().Equals(txtTCNo.Text.Trim().ToLower())
                                  select l).ToList();

                    if (memberList.Count == 0)
                    {
                        EMembers member = new EMembers();
                        member.TCNo = txtTCNo.Text;
                        member.FirstName = txtAd.Text;
                        member.LastName = txtSoyad.Text;
                        member.Phone = txtCepNo.Text;
                        member.Address = txtAdres.Text;

                        bool sonuc = BLLMembers.InsertNewMember(member);
                        if (sonuc)
                        {
                            MessageBox.Show("Yeni üye kaydı başarıyla tamamlanmıştır!");
                            dataGridView1.DataSource = BLLMembers.GetAll();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aynı TC kimlik numarasına sahip personel zaten kayıtlıdır!");
                    }
                }
                else
                {
                    MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!");
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
            }
        }

        EMembers seciliuye;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliuye = (EMembers)dataGridView1.SelectedRows[0].DataBoundItem;

            txtTCNo.Text = seciliuye.TCNo;
            txtAd.Text = seciliuye.FirstName;
            txtSoyad.Text = seciliuye.LastName;
            txtCepNo.Text = seciliuye.Phone;
            txtAdres.Text = seciliuye.Address;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliuye != null)
            {
                if (!string.IsNullOrEmpty(txtAd.Text) & !string.IsNullOrEmpty(txtSoyad.Text) & !string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text))
                {
                    if (txtTCNo.Text.Length == 11)
                    {

                        EMembers member = new EMembers();
                        member.ID = seciliuye.ID;
                        member.TCNo = txtTCNo.Text;
                        member.FirstName = txtAd.Text;
                        member.LastName = txtSoyad.Text;
                        member.Phone = txtCepNo.Text;
                        member.Address = txtAdres.Text;

                        bool sonuc = BLLMembers.Update(member);
                        if (sonuc)
                        {
                            MessageBox.Show("Güncelleme başarılı!");
                            dataGridView1.DataSource = BLLMembers.GetAll();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemini yapmak istidiğiniz yazarı seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EMembers silinecekMember = (EMembers)dataGridView1.SelectedRows[0].DataBoundItem;
            if (silinecekMember != null)
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EMembers member = new EMembers();
                    member.ID = silinecekMember.ID;

                    bool sonuc = BLLMembers.Delete(member);
                    if (sonuc)
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        dataGridView1.DataSource = BLLMembers.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçiniz!");
            }
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
