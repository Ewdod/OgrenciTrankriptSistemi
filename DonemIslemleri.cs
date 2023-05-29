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
        public DonemIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donem d1 = new Donem(Convert.ToInt32(textBox1.Text));
            d1.Ekleme();
        }
    }
}
