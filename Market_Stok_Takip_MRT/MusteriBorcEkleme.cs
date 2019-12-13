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
            baglanti.sqlCalistir("update musteriler set devreden_borc=devreden_borc+"+ Convert.ToDecimal(textBox4.Text)+" where musteri_id="+musteri_id);
            baglanti.verileriTablodaGoster("select * from musteriler where musteri_id<>1 order by musteri_id", musteriler.dataGridView1);
            string cari_hesap_adi= baglanti.verileriOku("select * from musteriler where musteri_id="+musteri_id).Rows[0][1].ToString();
            baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,musteri_id) values(2,3,1,2,'"+DateTime.Now+"',"+  Convert.ToInt32(textBox4.Text).ToString()+",'"+ cari_hesap_adi + "',1,"+musteri_id+")");
            VeresiyeDefteri veresiye_defteri = (VeresiyeDefteri)Application.OpenForms["VeresiyeDefteri"];
            if (veresiye_defteri != null)
            {
                veresiye_defteri.textBox2.Text = baglanti.verileriOku("select devreden_borc from musteriler where musteri_id=" + musteri_id).Rows[0][0].ToString();
            }
            MessageBox.Show("Borç eklendi!", "Başarılı", MessageBoxButtons.OK);                                
            this.Hide();
        }
    }
}
