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

            baglan.verileriTablodaGoster("select * from musteriler where musteri_id<>1 order by musteri_id", dataGridView1);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorcEkleme musteri_borc_ekleme = new MusteriBorcEkleme();
            musteri_borc_ekleme.musteri_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_id"].Value.ToString());          
            musteri_borc_ekleme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriOdemesi musteri_odemesi = new MusteriOdemesi();
            musteri_odemesi.musteri_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_id"].Value.ToString());
            musteri_odemesi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["notlar"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["kayit_tarihi"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["devreden_borc"].Value.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select * from musteriler where musteri_id<>1 and ad_soyad like'%" + textBox11.Text + "%'", dataGridView1);
        }
    }
}
