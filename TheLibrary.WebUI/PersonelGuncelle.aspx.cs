﻿using __TheLibrary.BLL;
using __TheLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheLibrary.WebUI
{
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int personelID = Convert.ToInt32(Request.QueryString["personelID"].ToString());

                EEmployees employee = new EEmployees();
                employee = BLLEmployees.GetIdOnly(personelID);
                txtAdi.Text = employee.FirstName;
                txtSoyadi.Text = employee.LastName;
                txtTCNo.Text = employee.TCNo;
                txtCepNo.Text = employee.Phone;
                txtAdres.Text = employee.Address;
                txtKullaniciAdi.Text = employee.UserName;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTCNo.Text) & !string.IsNullOrEmpty(txtAdi.Text) & !string.IsNullOrEmpty(txtSoyadi.Text) & !string.IsNullOrEmpty(txtCepNo.Text) & !string.IsNullOrEmpty(txtAdres.Text) & !string.IsNullOrEmpty(txtKullaniciAdi.Text) & !string.IsNullOrEmpty(txtSifre.Text))
            {
                if (txtTCNo.Text.Length == 11)
                {
                    EEmployees guncellenecek = new EEmployees();
                    guncellenecek.ID = int.Parse(Request.QueryString["personelID"]);
                    guncellenecek.TCNo = txtTCNo.Text;
                    guncellenecek.FirstName = txtAdi.Text;
                    guncellenecek.LastName = txtSoyadi.Text;
                    guncellenecek.Phone = txtCepNo.Text;
                    guncellenecek.Address = txtAdres.Text;
                    guncellenecek.UserName = txtKullaniciAdi.Text;
                    guncellenecek.Password = txtSifre.Text;
                    bool sonuc = BLLEmployees.Update(guncellenecek);
                    if (sonuc)
                    {
                        Response.Write("<script>alert('Harika! Güncellendi!');</script>");
                        Response.Redirect("Personeller.aspx?scs=1");
                    }
                    else
                    {
                        Response.Write("<script>alert('Hay Aksi! Hata Oluştu!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('TC kimlik numarası 11 haneli olmalıdır!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Eksik bilgi girdiniz. Lütfen kontrol ediniz!')</script>");
            }
        }

    }
}