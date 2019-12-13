using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Market_Stok_Takip_MRT
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        public int musteri_id=0;
        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            if (musteri_id != 0)
            {
                textBox1.Text = baglanti.verileriOku("select ad_soyad from musteriler where musteri_id="+musteri_id).Rows[0][0].ToString();
                textBox2.Text = baglanti.verileriOku("select email from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
                textBox3.Text = baglanti.verileriOku("select telefon from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
                textBox4.Text = baglanti.verileriOku("select adres from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
                textBox5.Text = baglanti.verileriOku("select notlar from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
                textBox6.Text = baglanti.verileriOku("select devreden_borc from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)  //müşteri kayıt butonu
        {
            Musteriler musteriler = new Musteriler();
            baglanti.sqlCalistir("insert into musteriler (ad_soyad,email,telefon,adres,notlar,kayit_tarihi,devreden_borc) values ('"
             +textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+DateTime.Now + "','" + textBox6.Text + "')");
            MessageBox.Show("Müşteri Kaydı Yapıldı!", "Başarılı", MessageBoxButtons.OK);
            
            musteriler.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.sqlCalistir("update musteriler set ad_soyad='" + textBox1.Text + "',email='" + textBox2.Text + "',telefon='"+textBox3.Text+"',adres='"+
                textBox4.Text+"',notlar='"+textBox5.Text+"',devreden_borc="+textBox6.Text+" where musteri_id="+musteri_id);
            MessageBox.Show("Güncelleme yapıldı!", "Başarılı", MessageBoxButtons.OK);
        }
    }
}
