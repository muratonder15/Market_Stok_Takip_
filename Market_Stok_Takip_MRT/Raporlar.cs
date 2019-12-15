using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Market_Stok_Takip_MRT
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select h.islem_tarihi,ht.hareket_turu,h.barkod,us.urun_adi,format(h.alis_fiyati,'Currency') as alis_fiyati,format(h.satis_fiyati,'Currency') as satis_fiyati,h.miktar,format(h.kar,'Currency') as kar,h.kdv_orani,ot.odeme_turu,format(h.toplam_tutar,'Currency') as toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +               
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView1);

            int veresiye_satislar = 0;
            int nakit_satislar = 0;
            int çek_satislar = 0;
            int kredi_karti_satislar = 0;
            int kar = 0;
            int musteri_odemesi_nakit = 0;
            int musteri_odemesi_kredi_karti = 0;
            int musteri_odemesi_kredi_cek = 0;
            int toptanciya_odeme_nakit = 0;
            int toptanciya_odeme_kredi_karti = 0;
            int toptanciya_odeme_cek = 0;
            int urun_girisi_nakit = 0;
            int urun_girisi_kredi_karti = 0;
            int urun_girisi_cek = 0;
            int iade_edilen_nakit = 0;
            int urun_alinan_nakit = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    veresiye_satislar += Convert.ToInt32(dataGridView1.Rows[i].Cells["toplam_tutar"].Value);
            //}
            
            
            textBox1.Text = baglanti.verileriOku("select  format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox2.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox3.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox4.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox5.Text = baglanti.verileriOku("select format(sum(kar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox6.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox7.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox8.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox9.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox10.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox11.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox12.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox13.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox14.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox15.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();// toptancıya iade
            textBox16.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
           
            textBox18.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox19.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString(); // toptancıya iade eklenecek
            textBox20.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox21.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox22.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();
            textBox23.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59')").Rows[0][0].ToString();

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            baglanti.verileriComboListele("select * from urun_grubu where urun_grup_id<>1","urun_grup_adi","urun_grup_id",comboBox2);
            
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select h.islem_tarihi,ht.hareket_turu,h.barkod,us.urun_adi,format(h.alis_fiyati,'Currency') as alis_fiyati,format(h.satis_fiyati,'Currency') as satis_fiyati,h.miktar,format(h.kar,'Currency') as kar,h.kdv_orani,ot.odeme_turu,format(h.toplam_tutar,'Currency') as toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') " +
                "and us.urun_adi like '%" +textBox17.Text+"%' "+
                //"and us.urun_grup_id=" + comboBox2.SelectedValue.ToString() +
                " order by h.islem_tarihi desc", dataGridView1);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExceleAktar excel = new ExceleAktar();
            excel.excelExport(dataGridView1);
        }

        

       
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            baglanti.verileriTablodaGoster("select h.islem_tarihi,ht.hareket_turu,h.barkod,us.urun_adi,format(h.alis_fiyati,'Currency') as alis_fiyati,format(h.satis_fiyati,'Currency') as satis_fiyati,h.miktar,format(h.kar,'Currency') as kar,h.kdv_orani,ot.odeme_turu,format(h.toplam_tutar,'Currency') as toplam_tutar,h.cari_hesap_adi,k.ad_soyad as islemi_yapan from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') " +
                "and us.urun_adi like '%" + textBox17.Text + "%' " +
                "and us.urun_grup_id="+comboBox2.SelectedValue.ToString()+
                " order by h.islem_tarihi desc", dataGridView1);

            //textBox1.Text = baglanti.verileriOku("select  format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox2.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox3.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox4.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //          textBox5.Text = baglanti.verileriOku("select format(sum(kar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox6.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox7.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox8.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            // textBox9.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox10.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox11.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox12.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox13.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox14.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and odeme_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox15.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();// toptancıya iade
            //textBox16.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and odeme_turu_kodu=2 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();

            //textBox18.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox19.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=4 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString(); // toptancıya iade eklenecek
            //textBox20.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=3 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox21.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=6 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox22.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=5 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            //textBox23.Text = baglanti.verileriOku("select format(sum(toplam_tutar),'Currency') from hareketler where hareket_turu_kodu=1 and islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') and islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
        }
    }
}
