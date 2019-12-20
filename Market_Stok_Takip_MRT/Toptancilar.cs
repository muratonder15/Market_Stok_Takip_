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
            textBox2.Text = baglanti.verileriOku("select format(sum(toptanci_alacak),'Currency') from toptancilar where aktif_mi=true and toptanci_id<>1").Rows[0][0].ToString();
            baglanti.verileriTablodaGoster("select toptanci_id,toptanci_adi,format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where aktif_mi=true and toptanci_id<>1", dataGridView1);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select * from toptancilar where aktif_mi=true and toptanci_id<>1 and toptanci_adi like'%"+textBox1.Text+"%'", dataGridView1);
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
            toptanci_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["toptanci_id"].Value); 
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToptanciKayit toptanci_kayit = new ToptanciKayit();                                       
            
            toptanci_kayit.toptanci_id = toptanci_id;
            toptanci_kayit.btnGuncelle.Visible = true;
            toptanci_kayit.btnKaydet.Visible = false;
            
            toptanci_kayit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Iadeler iadeler = new Iadeler();
            iadeler.toptanci_id = toptanci_id;
            iadeler.btnToptanciNakit.Visible = true;
            iadeler.btnToptanciyaEkle.Visible = true;
            iadeler.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Toptanci Bilgisini Silerseniz Borç ve Alacak Bilgileri de . Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglanti.sqlCalistir("update toptancilar set aktif_mi=false where toptanci_id=" + toptanci_id);
                baglanti.verileriTablodaGoster("select toptanci_id,toptanci_adi,format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where aktif_mi=true and toptanci_id<>1", dataGridView1);
            }
        }
    }
}
