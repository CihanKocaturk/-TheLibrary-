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
    public partial class Yeni_Personel_Kayıt : Form
    {
        public Yeni_Personel_Kayıt()
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

        private void Yeni_Personel_Kayıt_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BLLEmployees.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdi.Text) & !string.IsNullOrEmpty(txtSoyadi.Text) & !string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text) & !string.IsNullOrEmpty(txtUserName.Text) & !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtTCNo.Text.Length == 11)
                {
                    List<EEmployees> employeeList = BLLEmployees.GetAll();
                    employeeList = (from l in employeeList
                                    where l.TCNo.Trim().ToLower().Equals(txtTCNo.Text.Trim().ToLower())
                                    select l).ToList();

                    if (employeeList.Count == 0)
                    {
                        EEmployees employee = new EEmployees();
                        employee.TCNo = txtTCNo.Text;
                        employee.FirstName = txtAdi.Text;
                        employee.LastName = txtSoyadi.Text;
                        employee.Phone = txtCepNo.Text;
                        employee.Address = txtAdres.Text;
                        employee.UserName = txtUserName.Text;
                        employee.Password = txtPassword.Text;

                        bool sonuc = BLLEmployees.InsertNewEmployee(employee);
                        if (sonuc)
                        {
                            MessageBox.Show("Yeni personel kaydı başarıyla tamamlanmıştır!");
                            dataGridView1.DataSource = BLLEmployees.GetAll();
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

        EEmployees seciliPersonel;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliPersonel = (EEmployees)dataGridView1.SelectedRows[0].DataBoundItem;

            txtTCNo.Text = seciliPersonel.TCNo;
            txtAdi.Text = seciliPersonel.FirstName;
            txtSoyadi.Text = seciliPersonel.LastName;
            txtCepNo.Text = seciliPersonel.Phone;
            txtAdres.Text = seciliPersonel.Address;
            txtUserName.Text = seciliPersonel.UserName;           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliPersonel != null)
            {
                if (txtTCNo.Text.Length == 11)
                {
                    if (!string.IsNullOrEmpty(txtAdi.Text) & !string.IsNullOrEmpty(txtSoyadi.Text) & !string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text) & !string.IsNullOrEmpty(txtUserName.Text) & !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        EEmployees personel = new EEmployees();
                        personel.ID = Convert.ToInt32(seciliPersonel.ID);
                        personel.TCNo = txtTCNo.Text;
                        personel.FirstName = txtAdi.Text;
                        personel.LastName = txtSoyadi.Text;
                        personel.Phone = txtCepNo.Text;
                        personel.Address = txtAdres.Text;
                        personel.UserName = txtUserName.Text;
                        personel.Password = txtPassword.Text;

                        bool sonuc = BLLEmployees.Update(personel);
                        if (sonuc)
                        {
                            MessageBox.Show("Güncelleme başarılı!");
                            dataGridView1.DataSource = BLLEmployees.GetAll();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik bilgi girdiniz. Lütfen kontrol ediniz!");
                    }
                }
                else
                {
                    MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır!");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi yapmak istediğiniz personelin üzerine çift tıklayarak seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EEmployees silinecekEmployee = (EEmployees)dataGridView1.SelectedRows[0].DataBoundItem;

            if (silinecekEmployee != null)
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EEmployees employee = new EEmployees();
                    employee.ID = silinecekEmployee.ID;

                    if (BLLEmployees.Delete(employee))
                    {
                        MessageBox.Show("Silme işleminiz başarıyla tamamlanmıştır.");
                        dataGridView1.DataSource = BLLEmployees.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçiniz!");
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
