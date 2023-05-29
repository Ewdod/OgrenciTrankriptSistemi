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
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ders = new Dersler() { DersAdi = txtDersAdi.Text, DersKisaltma = txtDersKisaltma.Text, DersKredi = Convert.ToInt32(txtDersKredi.Text) };

            _ov.DerslerVeri.Add(ders); // OkulVeri DerslerVeri Sınıfına veri girişi yaptık
            lstDerslerListesi.Items.Add(ders); 
        }
    }
}
