using TranskriptData.Concrete;

namespace OgrenciTrankriptSistemi
{
    public partial class Form1 : Form
    {
        OkulVeri ov = new OkulVeri();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            new OgrenciIslemleri(ov).ShowDialog();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            new DersIslemleri(ov).ShowDialog();
        }

        private void btnDonemIslemleri_Click(object sender, EventArgs e)
        {
            
        }
    }
}