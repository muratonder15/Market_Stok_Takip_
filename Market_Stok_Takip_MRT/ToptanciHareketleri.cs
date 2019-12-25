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
    public partial class ToptanciHareketleri : Form
    {
        public ToptanciHareketleri()
        {
            InitializeComponent();
        }
        public int toptanci_id;
        Baglanti baglanti = new Baglanti();
        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select h.islem_tarihi,ht.hareket_turu,h.toplam_tutar from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.hareket_turu_kodu in (1,7) " +
                "and h.toptanci_id=" + toptanci_id +
                " and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView1);

            baglanti.verileriTablodaGoster("select h.islem_tarihi,us.urun_adi,h.miktar,h.toplam_tutar,ot.odeme_turu from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>=CDATE('" + dateTimePicker1.Value.ToShortDateString() + " 00:00:00') " +
                "and h.hareket_turu_kodu in (6,5) " +
                "and h.toptanci_id=" + toptanci_id +
                " and h.islem_tarihi<=CDATE('" + dateTimePicker2.Value.ToShortDateString() + " 23:59:59') order by h.islem_tarihi desc", dataGridView2);
        }

        private void ToptanciHareketleri_Load(object sender, EventArgs e)
        {
            textBox1.Text = baglanti.verileriOku("select toptanci_adi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            textBox2.Text= baglanti.verileriOku("select toptanci_alacak from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToptanciBorcEkleme toptanci_borc_ekleme = new ToptanciBorcEkleme();
            toptanci_borc_ekleme.toptanci_id = toptanci_id;
            toptanci_borc_ekleme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToptanciOdemesi toptanci_odemesi = new ToptanciOdemesi();
            toptanci_odemesi.toptanci_id = toptanci_id;
            toptanci_odemesi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExceleAktar excel = new ExceleAktar();
            excel.excelExport(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExceleAktar excel = new ExceleAktar();
            excel.excelExport(dataGridView2);
        }
    }
}
