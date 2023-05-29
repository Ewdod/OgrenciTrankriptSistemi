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
    public partial class DonemIslemleri : Form
    {
        OkulVeri _ov;
        public DonemIslemleri(OkulVeri ov)
        {
            _ov = ov;
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            lstDonemler.Items.AddRange(_ov.DonemVeri.ToArray());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // var donem = new Donem(Convert.ToInt32(txtKacinciDonem.Text));
            lstDonemler.Items.Clear();
            Donem d1 = new Donem(Convert.ToInt32(txtKacinciDonem.Text));
            _ov.DonemVeri.Add(d1);
            Listele();
            
        }


    }
}
