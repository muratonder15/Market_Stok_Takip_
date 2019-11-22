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
    public partial class MusteriBorcEkleme : Form
    {
        public MusteriBorcEkleme()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        public int musteri_id;
        private void MusteriBorcEkleme_Load(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            DataTable table = new DataTable();
            table = baglanti.verileriOku("select *  from musteriler where musteri_id=" +  musteri_id);
            textBox1.Text= table.Rows[0][1].ToString();
            textBox2.Text = table.Rows[0][7].ToString();
            textBox3.Text = DateTime.Now.ToString();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Musteriler musteriler = (Musteriler)Application.OpenForms["Musteriler"];
            baglanti.sqlCalistir("update musteriler set devreden_borc="+ (Convert.ToInt32(textBox2.Text)+ Convert.ToInt32(textBox4.Text))+" where musteri_id="+musteri_id);
            baglanti.verileriTablodaGoster("select * from musteriler where musteri_id<>1 order by musteri_id", musteriler.dataGridView1);
            baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,islem_tarihi,toplam_tutar,islemi_yapan_kullanici_kodu) values(2,3,'"+DateTime.Now+"',"+ (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text)).ToString()+",1)");
            //log ekleme hatası veriyor.
            MessageBox.Show("Borç eklendi!", "Başarılı", MessageBoxButtons.OK);                                
            this.Hide();
        }
    }
}
