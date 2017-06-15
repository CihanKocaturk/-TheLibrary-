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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void yeniKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapKayıt kitapKayit = new KitapKayıt();
            kitapKayit.MdiParent = this;
            kitapKayit.Show();
        }

        private void yeniYazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarKayıt yazarKayit = new YazarKayıt();
            yazarKayit.MdiParent = this;
            yazarKayit.Show();
        }

        private void yayıneviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YayineviEkle yayineviEkle = new YayineviEkle();
            yayineviEkle.MdiParent = this;
            yayineviEkle.Show();
        }

        private void türToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriKayit kategoriKayit = new KategoriKayit();
            kategoriKayit.MdiParent = this;
            kategoriKayit.Show();
        }

        private void rafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RafKayit rafKayit = new RafKayit();
            rafKayit.MdiParent = this;
            rafKayit.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yeni_Personel_Kayıt personelKayit = new Yeni_Personel_Kayıt();
            personelKayit.MdiParent = this;
            personelKayit.Show();
        }

        private void üyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yeni_Üye_Kayıt uyeKayit = new Yeni_Üye_Kayıt();
            uyeKayit.MdiParent = this;
            uyeKayit.Show();
        }

        private void ödünçKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapKiralama kitapKiralama = new KitapKiralama();
            kitapKiralama.MdiParent = this;
            kitapKiralama.Show();
        }

        private void kitapKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_Listesi kitapListesi = new Kitap_Listesi();
            kitapListesi.MdiParent = this;
            kitapListesi.Show();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_Listesi kitapListesi = new Kitap_Listesi();
            kitapListesi.MdiParent = this;
            kitapListesi.Show();
        }

        private void yayınevleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazar_Listesi yazarListesi = new Yazar_Listesi();
            yazarListesi.MdiParent = this;
            yazarListesi.Show();
        }

        private void yazarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazar_Listesi yazarListesi = new Yazar_Listesi();
            yazarListesi.MdiParent = this;
            yazarListesi.Show();
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yayınevleri_Listesi yayinevleriListesi = new Yayınevleri_Listesi();
            yayinevleriListesi.MdiParent = this;
            yayinevleriListesi.Show();
        }

        private void kitapTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap_Türleri KitapTurleri = new Kitap_Türleri();
            KitapTurleri.MdiParent = this;
            KitapTurleri.Show();
        }

        private void raflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raflar Raflar = new Raflar();
            Raflar.MdiParent = this;
            Raflar.Show();
        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Uye_Listesi uyeListesi = new Uye_Listesi();
            uyeListesi.MdiParent = this;
            uyeListesi.Show();
        }

        private void personelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Personel_Listesi personelListesi = new Personel_Listesi();
            personelListesi.MdiParent = this;
            personelListesi.Show();
        }

        private void ödünçVerilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralananKitaplar kiralananKitaplar = new KiralananKitaplar();
            kiralananKitaplar.MdiParent = this;
            kiralananKitaplar.Show();
        }

        private void gelişmişAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelismisArama gelismisArama = new GelismisArama();
            gelismisArama.MdiParent = this;
            gelismisArama.Show();
        }

        private void gelişmişAramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GelismisArama gelismisArama = new GelismisArama();
            gelismisArama.MdiParent = this;
            gelismisArama.Show();
        }

        private void kitapTeslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapTeslimFormu kitapTeslimAl = new KitapTeslimFormu();
            kitapTeslimAl.MdiParent = this;
            kitapTeslimAl.Show();
        }
    }
}
