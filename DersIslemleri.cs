using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptData.Concrete;

namespace OgrenciTrankriptSistemi
{
    public partial class DersIslemleri : Form
    {
        OkulVeri _ov;
        public DersIslemleri(OkulVeri ov)
        {
            _ov = ov;
            InitializeComponent();
            Listele();

        }

        private void Listele()
        {
            lstDerslerListesi.Items.Clear();
            foreach (Donem item in _ov.DonemVeri)
            {
                lstDerslerListesi.Items.Add(item.ToString());
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Dersler ders = new Dersler() { DersAdi = txtDersAdi.Text, DersKisaltma = txtDersKisaltma.Text, DersKredi = Convert.ToInt32(txtDersKredi.Text) };
            Donem donem = new Donem() { DonemDersleri = ders, KacinciDonem = Convert.ToInt32(txtDonem.Text) };
            _ov.DonemVeri.Add(donem);
            _ov.DerslerVeri.Add(ders); // OkulVeri DerslerVeri Sınıfına veri girişi yaptık
            Listele();
        }

        private void lstDerslerListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButonSaklama();
            foreach (Dersler item in lstDerslerListesi.SelectedItems)
            {
                // lstDerslerListesindeki seçili indeksin itemlarında derslerin propertylerine ulaşmak için foreachle döndüm
                txtDersAdi.Text = item.DersAdi;
                txtDersKisaltma.Text = item.DersKisaltma;
                txtDersKredi.Text = item.DersKredi.ToString();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _ov.DerslerVeri.RemoveAt(lstDerslerListesi.SelectedIndex);
            Listele();
            ButonSaklama();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Dersler seciliDers = (Dersler)lstDerslerListesi.SelectedItem;
            seciliDers.DersAdi = txtDersAdi.Text;
            seciliDers.DersKisaltma = txtDersKisaltma.Text;
            seciliDers.DersKredi = Convert.ToInt32(txtDersKredi.Text);
            Listele();
            ButonSaklama();
        }

        private void ButonSaklama()
        {
            if (lstDerslerListesi.SelectedItems.Count == 1)  // Listede herhangi bir item seçili değilse güncelle ve sil butonları false durunmunda
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else
            {
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
        }
    }
}
