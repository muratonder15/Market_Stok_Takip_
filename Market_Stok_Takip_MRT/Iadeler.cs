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
    public partial class Iadeler : Form
    {
        public Iadeler()
        {
            InitializeComponent();
        }
        public int urun_id;
        public DataTable tablo = new DataTable();
        Baglanti baglanti = new Baglanti();
        public int musteri_id;
        private void Iadeler_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ürün id", typeof(int));
            tablo.Columns.Add("ürün barkod", typeof(string));
            tablo.Columns.Add("urun adı", typeof(string));
            //tablo.Columns.Add("kalan stok", typeof(int));
            tablo.Columns.Add("satış fiyatı", typeof(int));
            tablo.Columns.Add("miktarı", typeof(int));
            tablo.Columns.Add("toplam tutar", typeof(int));
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 != 0)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                {

                    string id = baglanti.verileriOku("select id from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string alis_fiyati = baglanti.verileriOku("select alis_fiyati from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string satis_fiyati = baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string kdv_orani = baglanti.verileriOku("select kdv_orani from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string miktar = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string toplam_tutar = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu," +
                        "islem_tarihi,barkod,urun_id,alis_fiyati,satis_fiyati,miktar,kar,kdv_orani," +
                        "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(5,2,'" + DateTime.Now + "'," + barkod +
                        "," + id + "," + alis_fiyati + "," + satis_fiyati + "," + miktar + "," + (Convert.ToInt32(satis_fiyati) - Convert.ToInt32(alis_fiyati)).ToString() +
                        "," + kdv_orani + ",2," + toplam_tutar + ",'',1," + musteri_id + ")");
                    baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok+" + miktar + " where id=" + id);
                }
                MessageBox.Show("İade işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunListesi urun_listesi = new UrunListesi();
            urun_listesi.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (baglanti.verileriOku("select count(*) from urun_stok where barkod=" + textBox2.Text).Rows[0][0].ToString() != "0")
                {
                    string id = baglanti.verileriOku("select id from urun_stok where barkod=" + textBox2.Text).Rows[0][0].ToString();
                    string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                    string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                    int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                    int satis_fiyati = Convert.ToInt32(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                    tablo.Rows.Add(id, barkod, urun_adi, satis_fiyati, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text) * satis_fiyati);
                    dataGridView1.DataSource = tablo;
                    int toplam = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    textBox3.Text = toplam.ToString();
                    textBox2.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 != 0)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                {

                    string id = baglanti.verileriOku("select id from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string alis_fiyati = baglanti.verileriOku("select alis_fiyati from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string satis_fiyati = baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string kdv_orani = baglanti.verileriOku("select kdv_orani from urun_stok where id=" + dataGridView1.Rows[i].Cells[0].Value).Rows[0][0].ToString();
                    string miktar = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string toplam_tutar = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu," +
                        "islem_tarihi,barkod,urun_id,alis_fiyati,satis_fiyati,miktar,kar,kdv_orani," +
                        "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(5,2,'" + DateTime.Now + "'," + barkod +
                        "," + id + "," + alis_fiyati + "," + satis_fiyati + "," + miktar + "," + (Convert.ToInt32(satis_fiyati) - Convert.ToInt32(alis_fiyati)).ToString() +
                        "," + kdv_orani + ",6," + toplam_tutar + ",'',1," + musteri_id + ")");
                    baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok+" + miktar + " where id=" + id);
                }
                Musteriler musteriler = (Musteriler)Application.OpenForms["Musteriler"];
                baglanti.sqlCalistir("update musteriler set devreden_borc=devreden_borc-" + textBox3.Text + " where musteri_id=" + musteri_id);
                baglanti.verileriTablodaGoster("select * from musteriler where musteri_id<>1 order by musteri_id", musteriler.dataGridView1);
                string cari_hesap_adi = baglanti.verileriOku("select * from musteriler where musteri_id=" + musteri_id).Rows[0][1].ToString();
                //baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(3,1,6" + comboBox1.SelectedValue.ToString() + ",2,'" + DateTime.Now + "'," + Convert.ToInt32(textBox4.Text).ToString() + ",'" + cari_hesap_adi + "',1," + musteri_id + ")");
                
                MessageBox.Show("İade işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
