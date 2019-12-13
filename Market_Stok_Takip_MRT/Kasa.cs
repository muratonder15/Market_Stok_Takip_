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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select h.barkod,h.islem_tarihi,it.islem_turu,ht.hareket_turu,us.urun_adi,h.toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString()+" 00:00:00') " +
                "and h.islem_turu_kodu in (1,2) "+
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString()+" 23:59:59') order by h.islem_tarihi desc", dataGridView1);

            textBox1.Text=baglanti.verileriOku("select sum(h.toplam_tutar) from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_turu_kodu in (1) " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

            textBox2.Text= baglanti.verileriOku("select sum(toplam_tutar) from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_turu_kodu in (2) " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

            textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();

        }

        private void Kasa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                baglanti.verileriTablodaGoster("select h.barkod,h.islem_tarihi,it.islem_turu,ht.hareket_turu,us.urun_adi,h.toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
               "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
               "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
               "inner join urun_stok us on h.urun_id=us.id) " +
               "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
               "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
               "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
               "and h.islem_turu_kodu in (1,2) " +
               "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView1);

                textBox1.Text = baglanti.verileriOku("select sum(h.toplam_tutar) from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_turu_kodu in (1) " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox2.Text = baglanti.verileriOku("select sum(toplam_tutar) from (((((hareketler h " +
                    "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                    "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                    "inner join urun_stok us on h.urun_id=us.id) " +
                    "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                    "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                    "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                    "and h.islem_turu_kodu in (2) " +
                    "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                baglanti.verileriTablodaGoster("select h.barkod,h.islem_tarihi,it.islem_turu,ht.hareket_turu,us.urun_adi,h.toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
               "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
               "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
               "inner join urun_stok us on h.urun_id=us.id) " +
               "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
               "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
               "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
               "and h.islem_turu_kodu in (1) " +
               "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView1);

                textBox1.Text = baglanti.verileriOku("select sum(h.toplam_tutar) from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_turu_kodu in (1) " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox2.Text = baglanti.verileriOku("select sum(toplam_tutar) from (((((hareketler h " +
                    "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                    "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                    "inner join urun_stok us on h.urun_id=us.id) " +
                    "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                    "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                    "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                    "and h.islem_turu_kodu in (2) " +
                    "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                baglanti.verileriTablodaGoster("select h.barkod,h.islem_tarihi,it.islem_turu,ht.hareket_turu,us.urun_adi,h.toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
               "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
               "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
               "inner join urun_stok us on h.urun_id=us.id) " +
               "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
               "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
               "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
               "and h.islem_turu_kodu in (2) " +
               "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView1);

                textBox1.Text = baglanti.verileriOku("select sum(h.toplam_tutar) from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_turu_kodu in (1) " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox2.Text = baglanti.verileriOku("select sum(toplam_tutar) from (((((hareketler h " +
                    "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                    "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                    "inner join urun_stok us on h.urun_id=us.id) " +
                    "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                    "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                    "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                    "and h.islem_turu_kodu in (2) " +
                    "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

                textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
        }
    }
}
