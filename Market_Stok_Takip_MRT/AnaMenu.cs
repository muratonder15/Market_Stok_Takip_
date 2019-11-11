using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Stok_Takip_MRT
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGiris urunGiris = new UrunGiris();
            urunGiris.Show();
            //this.Hide();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();

        }

        private void musteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }
    }
}
