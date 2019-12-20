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
    public partial class MusteriOdemesi : Form
    {
        public MusteriOdemesi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        public int musteri_id;
        AnaMenu ana_menu = (AnaMenu)Application.OpenForms["AnaMenu"];
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = (Musteriler)Application.OpenForms["Musteriler"];
            baglanti.sqlCalistir("update musteriler set devreden_borc=" + (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox4.Text)) + " where musteri_id=" + musteri_id);
            baglanti.verileriTablodaGoster("select * from musteriler where musteri_id<>1 and aktif_mi=true order by musteri_id", musteriler.dataGridView1);
            string cari_hesap_adi = baglanti.verileriOku("select * from musteriler where musteri_id=" + musteri_id).Rows[0][1].ToString();
            baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(3,1," + comboBox1.SelectedValue.ToString() +",2,'" + DateTime.Now + "'," + Convert.ToInt32(textBox4.Text).ToString() + ",'" + cari_hesap_adi + "',"+ana_menu.kullanici_kodu+","+musteri_id+")");
            VeresiyeDefteri veresiye_defteri = (VeresiyeDefteri)Application.OpenForms["VeresiyeDefteri"];
            veresiye_defteri.textBox2.Text = baglanti.verileriOku("select devreden_borc from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            MessageBox.Show("Borç Ödemesi Gerçekleşti!", "Başarılı", MessageBoxButtons.OK);
            this.Hide();
        }

        private void MusteriOdemesi_Load(object sender, EventArgs e)
        {
            baglanti.verileriComboListele("select * from odeme_turleri where odeme_kodu<>1", "odeme_turu", "odeme_kodu", comboBox1);
            Musteriler musteriler = new Musteriler();
            DataTable table = new DataTable();
            table = baglanti.verileriOku("select *  from musteriler where musteri_id=" + musteri_id);
            textBox1.Text = table.Rows[0][1].ToString();
            textBox2.Text = table.Rows[0][7].ToString();
            textBox3.Text = DateTime.Now.ToString();
        }
    }
}
