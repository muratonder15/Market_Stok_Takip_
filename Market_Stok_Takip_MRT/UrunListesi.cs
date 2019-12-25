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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        DataTable tablo = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            Iadeler iadeler = (Iadeler)Application.OpenForms["Iadeler"];
            iadeler.urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            string id = baglanti.verileriOku("select id from urun_stok where id=" + iadeler.urun_id).Rows[0][0].ToString();
            string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
            string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
            int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
            double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
            iadeler.tablo.Rows.Add(id, barkod, urun_adi, satis_fiyati, 1, 1 * satis_fiyati);
            iadeler.dataGridView1.DataSource = iadeler.tablo;
            double toplam = 0;                    
            toplam = Convert.ToDouble(iadeler.textBox3.Text);
            toplam += 1 * satis_fiyati;
            iadeler.textBox3.Text = toplam.ToString();
            this.Hide();
        }

        private void UrunListesi_Load(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select id,barkod,urun_adi,satis_fiyati from urun_stok where id<>2 and mevcut_stok>0 and urun_varmi=true", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select id,barkod,urun_adi from urun_stok where id<>2 and urun_varmi=true and urun_adi like'%" + textBox1.Text + "%'" 
               , dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sayimİslemi sayim_islemi = (Sayimİslemi)Application.OpenForms["Sayimİslemi"];
            sayim_islemi.urun_id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            int id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
            string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
            sayim_islemi.textBox1.Text = barkod;
            sayim_islemi.textBox2.Text = urun_adi;
            sayim_islemi.button2.Enabled = true;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Satisİslemi satis_islemi = (Satisİslemi)Application.OpenForms["Satisİslemi"];
            satis_islemi.urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
            string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
            int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
            double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
            satis_islemi.tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
            satis_islemi.dataGridView1.DataSource = satis_islemi.tablo;
            double toplam = 0;
            for (int i = 0; i < satis_islemi.dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToDouble(satis_islemi.dataGridView1.Rows[i].Cells[6].Value);
            }
            satis_islemi.textBox1.Text = toplam.ToString();
            this.Close();
        }
    }
}
