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
    public partial class Musteriler : Form
    {
        Baglanti baglan = new Baglanti();

        //public int musteri_id;
        MusteriBorcEkleme musteri_borc_ekleme = new MusteriBorcEkleme();
        public int musteri_id;
        public Musteriler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            textBox10.Text = baglan.verileriOku("select format(sum(devreden_borc),'Currency') from musteriler where musteri_id<>0 and aktif_mi=true").Rows[0][0].ToString();
            baglan.verileriTablodaGoster("select musteri_id,ad_soyad,format(devreden_borc,'Currency') as devreden_borc from musteriler where musteri_id<>1 and aktif_mi=true order by musteri_id", dataGridView1);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorcEkleme musteri_borc_ekleme = new MusteriBorcEkleme();
            musteri_borc_ekleme.musteri_id = musteri_id;          
            musteri_borc_ekleme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriOdemesi musteri_odemesi = new MusteriOdemesi();
            musteri_odemesi.musteri_id = musteri_id;
            musteri_odemesi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriKayit musteri_kayit = new MusteriKayit();
            musteri_kayit.btnGuncelle.Visible = true;
            musteri_kayit.musteri_id= musteri_id;
            musteri_kayit.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            //textBox1.Text = baglan.verileriOku("select ad_soyad from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox2.Text = baglan.verileriOku("select email from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox3.Text = baglan.verileriOku("select telefon from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox4.Text = baglan.verileriOku("select adres from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox5.Text = baglan.verileriOku("select notlar from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox6.Text = baglan.verileriOku("select kayit_tarihi from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            //textBox9.Text = baglan.verileriOku("select format(devreden_borc,'Currency') as devreden_borc from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select musteri_id,ad_soyad,format(devreden_borc,'Currency') as devreden_borc from musteriler where musteri_id<>1 and ad_soyad like'%" + textBox11.Text + "%'", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeresiyeDefteri veresiye_defteri = new VeresiyeDefteri();
            veresiye_defteri.musteri_id = musteri_id;
            veresiye_defteri.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Iadeler iadeler = (Iadeler)Application.OpenForms["Iadeler"];          
            
            Iadeler iadeler = new Iadeler();
            iadeler.musteri_id= musteri_id;
            iadeler.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Müşteri Bilgisini Silerseniz Sistemde Bulunan Kayıtlı Borçları da Silinecek. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglan.sqlCalistir("update musteriler set aktif_mi=false where musteri_id=" + musteri_id);
                baglan.verileriTablodaGoster("select musteri_id,ad_soyad,format(devreden_borc,'Currency') as devreden_borc from musteriler where musteri_id<>1 and aktif_mi=true order by musteri_id", dataGridView1);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            musteri_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_id"].Value);         
            textBox1.Text = baglan.verileriOku("select ad_soyad from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox2.Text = baglan.verileriOku("select email from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox3.Text = baglan.verileriOku("select telefon from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox4.Text = baglan.verileriOku("select adres from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox5.Text = baglan.verileriOku("select notlar from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox6.Text = baglan.verileriOku("select kayit_tarihi from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            textBox9.Text = baglan.verileriOku("select format(devreden_borc,'Currency') as devreden_borc from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
    }
}
