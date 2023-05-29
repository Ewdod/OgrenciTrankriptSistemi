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
    public partial class OgrenciIslemleri : Form
    {
        OkulVeri _ov;
        public OgrenciIslemleri(OkulVeri ov)
        {
            _ov = ov;
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            foreach (Dersler item in _ov.DerslerVeri)
            {
                cmbDersler.Items.Add(item.DersAdi);
            }
            
        }
    }
}
