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
            baglanti.verileriTablodaGoster("select h.barkod,h.islem_tarihi,it.islem_turu,ht.hareket_turu,us.urun_adi,h.toplam_tutar from (((((hareketler h " +
                "inner join hareket_turleri ht on h.hareket_turu_kodu=ht.hareket_kodu) " +
                "inner join islem_turleri it on h.islem_turu_kodu=it.islem_kodu) " +
                "inner join urun_stok us on h.urun_id=us.id) " +
                "inner join odeme_turleri ot on h.odeme_turu_kodu=ot.odeme_kodu) " +
                "inner join kullanicilar k on h.islemi_yapan_kullanici_kodu=k.kullanici_kodu) " +
                "where h.islem_tarihi>='"+dateTimePicker1.Value.ToString()+"' " +
                "and islem_tarihi<='"+dateTimePicker2.Value.ToString()+"'", dataGridView1);
        }
    }
}
