using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptData.Concrete;

namespace OgrenciTrankriptSistemi
{
    public partial class OgrenciIslemleri : Form
    {
        OkulVeri _ov;
        public OgrenciIslemleri(OkulVeri ov)
        {
            _ov = ov;
            InitializeComponent();
            ButonDegistir();
            Listele();
        }

        private void Listele()
        {
            foreach (Donem item in _ov.DonemVeri)
            {
                if (!cmbDonemler.Items.Contains(item.KacinciDonem))
                {
                    cmbDonemler.Items.Add(item.KacinciDonem);
                }
            }
            foreach (Ogrenci item in _ov.OgrenciVeri)
            {
                lstOgrenci.Items.Add(item);
            }
        }

        private void ButonDegistir()
        {
            if (lstOgrenci.SelectedItems.Count == 0)
                btnEkle.Text = "ÖĞRENCİ EKLE";
            else if (lstOgrenci.SelectedItems.Count == 1)
                btnEkle.Text = "EKLE";
        }

        private void lstOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButonSaklama()
        {
            if (lstOgrenci.SelectedItems.Count == 1)
                cmbDonemler.Enabled = true;
            else
                cmbDonemler.Enabled = false;
        }

        private void cmbDonemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDersler.Items.Clear();
            cmbDersler.Enabled = true;
            int seciliDonem = Convert.ToInt32(cmbDonemler.SelectedItem);
            foreach (Donem item in _ov.DonemVeri)
            {
                if (item.KacinciDonem == seciliDonem)
                {
                    cmbDersler.Items.Add(item.DonemDersleri.DersAdi);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "ÖĞRENCİ EKLE")
            {
                string ad = txtOgrenciAd.Text;
                string soyad = txtOgrenciSoyad.Text;
                int seciliDonem = Convert.ToInt32(cmbDonemler.SelectedItem);

                Donem donem = _ov.DonemVeri.FirstOrDefault(item => item.KacinciDonem == seciliDonem);
                if (donem != null)
                {
                    Ogrenci ogrenci = new Ogrenci() { Ad = ad, Soyad = soyad, Donem = donem };
                    _ov.OgrenciVeri.Add(ogrenci);
                    MessageBox.Show("Test");
                    // Ogrenci örneğini kullanarak gerekli işlemleri yapabilirsiniz
                }
                else
                {
                    // Seçilen dönem bulunamadı
                }
            }
            else
            {
                // Öğrenci güncelleme işlemi
            }
            Listele();
        }
    }
}
