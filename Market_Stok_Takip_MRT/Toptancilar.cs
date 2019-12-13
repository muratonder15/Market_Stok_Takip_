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
    public partial class Toptancilar : Form
    {
        public Toptancilar()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        int toptanci_id;
        private void Toptancilar_Load(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select toptanci_id,toptanci_adi,format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where toptanci_id<>1", dataGridView1);
        }

        

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select * from toptancilar where toptanci_id<>1 and toptanci_adi like'%"+textBox1.Text+"%'", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToptanciOdemesi toptanci_odemesi = new ToptanciOdemesi();
            toptanci_odemesi.toptanci_id = toptanci_id;
            toptanci_odemesi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToptanciBorcEkleme toptanci_borc_ekleme = new ToptanciBorcEkleme();
            toptanci_borc_ekleme.toptanci_id = toptanci_id;
            toptanci_borc_ekleme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToptanciKayit toptanci_kayit = new ToptanciKayit();
            toptanci_kayit.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToptanciHareketleri toptanci_hareketleri = new ToptanciHareketleri();
            toptanci_hareketleri.toptanci_id = toptanci_id;
            toptanci_hareketleri.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            toptanci_id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["toptanci_id"].Value);
            txtToptanciAdi.Text = baglanti.verileriOku("select toptanci_adi from toptancilar where toptanci_id="+toptanci_id).Rows[0][0].ToString();
            txtSirketYetkilisi.Text = baglanti.verileriOku("select sirket_yetkilisi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtEmail.Text = baglanti.verileriOku("select email from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtInternetAdresi.Text = baglanti.verileriOku("select internet_adresi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtVergiDairesi.Text = baglanti.verileriOku("select vergi_dairesi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtVergiNo.Text = baglanti.verileriOku("select vergi_no from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtAdres.Text = baglanti.verileriOku("select adres from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtTelefon.Text = baglanti.verileriOku("select telefon from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtNotlar.Text = baglanti.verileriOku("select notlar from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            txtBorc.Text = baglanti.verileriOku("select format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
        }
    }
}
