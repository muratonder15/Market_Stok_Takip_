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
    public partial class Satisİslemi : Form
    {
        public Satisİslemi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        public int urun_id;
        public int musteri_id=1;
        AnaMenu ana_menu = (AnaMenu)Application.OpenForms["AnaMenu"];
        public DataTable tablo = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button1.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button1.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }

        }

        private void Satisİslemi_Load(object sender, EventArgs e)
        {
            label7.Text = baglanti.verileriOku("select ad_soyad from kullanicilar where kullanici_kodu=" + ana_menu.kullanici_kodu).Rows[0][0].ToString();
            tablo.Columns.Add("ürün id", typeof(int));
            tablo.Columns.Add("ürün barkod", typeof(string));
            tablo.Columns.Add("urun adı", typeof(string));
            tablo.Columns.Add("kalan stok", typeof(int));
            tablo.Columns.Add("satış fiyatı", typeof(double));
            tablo.Columns.Add("miktarı", typeof(int));
            tablo.Columns.Add("toplam tutar", typeof(double));
            dataGridView1.DataSource = tablo;

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button1.Text'").Rows[0][0]) != 0)
            {
                button1.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button1.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button2.Text'").Rows[0][0]) != 0)
            {
                button2.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button2.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button3.Text'").Rows[0][0]) != 0)

            {
                button3.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button3.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button4.Text'").Rows[0][0]) != 0)
            {
                button4.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button4.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button5.Text'").Rows[0][0]) != 0)
            {
                button5.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button5.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button6.Text'").Rows[0][0]) != 0)
            {
                button6.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button6.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button7.Text'").Rows[0][0]) != 0)
            {
                button7.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button7.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button8.Text'").Rows[0][0]) != 0)
            {
                button8.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button8.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button9.Text'").Rows[0][0]) != 0)
            {
                button9.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button9.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button10.Text'").Rows[0][0]) != 0)
            {
                button10.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button10.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button11.Text'").Rows[0][0]) != 0)
            {
                button11.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button11.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button12.Text'").Rows[0][0]) != 0)
            {
                button12.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button12.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button13.Text'").Rows[0][0]) != 0)
            {
                button13.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button13.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button14.Text'").Rows[0][0]) != 0)
            {
                button14.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button14.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button15.Text'").Rows[0][0]) != 0)
            {
                button15.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button15.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button16.Text'").Rows[0][0]) != 0)
            {
                button16.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button16.Text' and ht.durum=true").Rows[0][1].ToString();
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button2.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button2.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button3.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button3.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button4.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button4.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button5.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button5.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button6.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button6.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button7.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button7.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button8.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button8.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button9.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button9.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button10.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button10.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button11.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button11.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button12.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button12.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button13.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button13.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button14.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button14.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button15.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button15.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "HIZLI TUŞ ATA")
            {
                HizliTusSecimi hizli_tus_secimi = new HizliTusSecimi();
                hizli_tus_secimi.hizli_tus_bilgisi = "button16.Text";
                hizli_tus_secimi.Show();
                this.Hide();
            }
            else
            {

                string id = baglanti.verileriOku("select ht.urun_id from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button16.Text' and ht.durum=true").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, 1, 1 * satis_fiyati);
                dataGridView1.DataSource = tablo;
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (baglanti.verileriOku("select count(*) from urun_stok where barkod=" + textBox5.Text).Rows[0][0].ToString() != "0")
                {
                    string id = baglanti.verileriOku("select id from urun_stok where barkod=" + textBox5.Text).Rows[0][0].ToString();
                    string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                    string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                    int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                    double satis_fiyati = Convert.ToDouble(baglanti.verileriOku("select satis_fiyati from urun_stok where id=" + id).Rows[0][0].ToString());
                    tablo.Rows.Add(id, barkod, urun_adi, stok_miktari, satis_fiyati, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox4.Text) * satis_fiyati);
                    dataGridView1.DataSource = tablo;
                    double toplam = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    }
                    textBox1.Text = string.Format("{0:0.##}", double.Parse(toplam.ToString()));
                    
                    textBox5.Clear();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
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
                    int miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    string toplam_tutar = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu," +
                        "islem_tarihi,barkod,urun_id,alis_fiyati,satis_fiyati,miktar,kar,kdv_orani," +
                        "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(4,1,'" + DateTime.Now + "'," + barkod +
                        "," + id + ",'" + alis_fiyati + "','" + satis_fiyati + "'," + miktar + ",'" + (Convert.ToDouble(satis_fiyati) - Convert.ToDouble(alis_fiyati)).ToString() +
                        "'," + kdv_orani + ",2,'" + toplam_tutar + "','',"+ana_menu.kullanici_kodu+","+musteri_id+")");
                    baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok-"+miktar+" where id="+id);
                }
                textBox2.Text = string.Format("{0:c}", double.Parse(textBox1.Text)); 
                textBox3.Text = string.Format("{0:c}", double.Parse("0"));
                MessageBox.Show("Satiş işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                   this.Hide();
            }
            else
            {
                MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.Hide();
            //this.Show();
            }
            else
            {
                MessageBox.Show("Miktar kısmına sıfırdan büyük bir değer giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
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
                            "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(4,1,'" + DateTime.Now + "'," + barkod +
                            "," + id + ",'" + alis_fiyati + "','" + satis_fiyati + "'," + miktar + ",'" + (Convert.ToDouble(satis_fiyati) - Convert.ToDouble(alis_fiyati)).ToString() +
                            "'," + kdv_orani + ",5,'" + toplam_tutar + "',''," + ana_menu.kullanici_kodu + "," + musteri_id + ")");
                        baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok-" + miktar + " where id=" + id);
                    }
                    textBox2.Text = string.Format("{0:c}", double.Parse(textBox1.Text)); 
                    textBox3.Text = string.Format("{0:c}", double.Parse("0"));
                    MessageBox.Show("Satiş işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Miktar kısmına sıfırdan büyük bir değer giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
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
                            "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(4,1,'" + DateTime.Now + "'," + barkod +
                            "," + id + ",'" + alis_fiyati + "','" + satis_fiyati + "'," + miktar + ",'" + (Convert.ToDouble(satis_fiyati) - Convert.ToDouble(alis_fiyati)).ToString() +
                            "'," + kdv_orani + ",3,'" + toplam_tutar + "',''," + ana_menu.kullanici_kodu + "," + musteri_id + ")");
                        baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok-" + miktar + " where id=" + id);

                    }
                    textBox2.Text = string.Format("{0:c}", double.Parse(textBox1.Text)); 
                    textBox3.Text = string.Format("{0:c}", double.Parse("0"));
                    MessageBox.Show("Satiş işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Miktar kısmına sıfırdan büyük bir değer giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            MusteriListesi musteri_listesi = new MusteriListesi();
            musteri_listesi.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
            {
                if (musteri_id == 1)
                {
                    MessageBox.Show("Veresiye için müşteri seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                                "odeme_turu_kodu,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(4,1,'" + DateTime.Now + "'," + barkod +
                                "," + id + ",'" + alis_fiyati + "','" + satis_fiyati + "'," + miktar + ",'" + (Convert.ToDouble(satis_fiyati) - Convert.ToDouble(alis_fiyati)).ToString() +
                                "'," + kdv_orani + ",4,'" + toplam_tutar + "',''," + ana_menu.kullanici_kodu + "," + musteri_id + ")");
                            baglanti.sqlCalistir("update urun_stok set mevcut_stok=mevcut_stok-" + miktar + " where id=" + id);
                        }
                        //label6.Text = String.Format("{0:0.##}", textBox1.Text.ToString());
                        baglanti.sqlCalistir("update musteriler set devreden_borc=devreden_borc+'" + textBox1.Text + "' where musteri_id=" + musteri_id);
                        string cari_hesap_adi = baglanti.verileriOku("select ad_soyad from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
                        baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(2,3,1,2,'" + DateTime.Now + "'," + textBox1.Text + ",'" + cari_hesap_adi + "',1," + musteri_id + ")");
                        MessageBox.Show("Satiş işlemi gerçekleşti", "Başarılı", MessageBoxButtons.OK);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("sepete ürün giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Miktar kısmına sıfırdan büyük bir değer giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            HizliTusSil hizli_tus_sil = new HizliTusSil();
            hizli_tus_sil.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Satış İşlemini bitirmeden çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            UrunListesi urun_listesi = new UrunListesi();
            urun_listesi.Show();
            urun_listesi.button3.Visible = true;
        }
    }
}
