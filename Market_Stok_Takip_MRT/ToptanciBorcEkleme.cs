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
    public partial class ToptanciBorcEkleme : Form
    {
        public ToptanciBorcEkleme()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        public int toptanci_id;
        private void ToptanciBorcEkleme_Load(object sender, EventArgs e)
        {
            Toptancilar toptancilar = new Toptancilar();
            DataTable table = new DataTable();
            table = baglanti.verileriOku("select *  from toptancilar where toptanci_id=" + toptanci_id);
            textBox1.Text = table.Rows[0][1].ToString();
            textBox2.Text = table.Rows[0][10].ToString();
            textBox3.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toptancilar toptancilar = (Toptancilar)Application.OpenForms["Toptancilar"];
            baglanti.sqlCalistir("update toptancilar set toptanci_alacak=" + (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text)) + " where toptanci_id=" + toptanci_id);
            baglanti.verileriTablodaGoster("select * from toptancilar where toptanci_id<>1 order by toptanci_id", toptancilar.dataGridView1);
            string cari_hesap_adi = baglanti.verileriOku("select * from toptancilar where toptanci_id=" + toptanci_id).Rows[0][1].ToString();
            baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu) values(7,3,1,2,'" + DateTime.Now + "'," + (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text)).ToString() + ",'" + cari_hesap_adi + "',1)");
            MessageBox.Show("Borç eklendi!", "Başarılı", MessageBoxButtons.OK);
            this.Hide();
        }
    }
}
