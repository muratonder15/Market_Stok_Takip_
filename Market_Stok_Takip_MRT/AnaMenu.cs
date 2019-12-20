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
        public int kullanici_kodu;
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Satisİslemi satis_islemi = new Satisİslemi();
            satis_islemi.Show();
        }

        private void stoklarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stoklar stoklar = new Stoklar();
            stoklar.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Stoklar stoklar = new Stoklar();
            stoklar.Show();
        }

        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stoklar stoklar = new Stoklar();
            stoklar.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void satisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satisİslemi satis_islemi = new Satisİslemi();
            satis_islemi.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            UrunGiris urun_giris = new UrunGiris();
            urun_giris.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Toptancilar toptancilar = new Toptancilar();
            toptancilar.Show();
        }

        private void toptanciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToptanciKayit toptanci_kayit = new ToptanciKayit();
            toptanci_kayit.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
