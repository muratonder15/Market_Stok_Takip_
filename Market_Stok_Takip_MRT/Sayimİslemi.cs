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
    public partial class Sayimİslemi : Form
    {
        public Sayimİslemi()
        {
            InitializeComponent();
        }
        int sayimda_sayilan,aradaki_fark = 0;

        DataTable tablo = new DataTable();
        Baglanti baglanti = new Baglanti();
        private void Sayimİslemi_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("barkod no", typeof(string));
            tablo.Columns.Add("ürün adı", typeof(string));
            tablo.Columns.Add("sayımda sayılan", typeof(int));
            tablo.Columns.Add("stokta görünen", typeof(int));
            tablo.Columns.Add("aradaki fark", typeof(int));
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.verileriOku("select count(*) from urun_stok where urun_adi like '%" + textBox2.Text + "%' and urun_varmi=true and mevcut_stok>0 ").Rows[0][0].ToString()!="0")
            {
                string id = baglanti.verileriOku("select id from urun_stok where urun_adi like '%" + textBox2.Text + "%' and urun_varmi=true and mevcut_stok>0 ").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                sayimda_sayilan = sayimda_sayilan + Convert.ToInt32(textBox3.Text);

                tablo.Rows.Add(barkod, urun_adi, sayimda_sayilan, stok_miktari, aradaki_fark);
                dataGridView1.DataSource = tablo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
