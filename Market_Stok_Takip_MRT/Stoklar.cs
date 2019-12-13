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
    public partial class Stoklar : Form
    {
        Baglanti baglan = new Baglanti();
        public Stoklar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.satis_fiyati,'Currency') as satis_fiyati,format(us.alis_fiyati,'Currency') as alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2", dataGridView1);
            textBox10.Text = baglan.verileriOku("select count(*) from urun_stok").Rows[0][0].ToString();
            textBox9.Text = baglan.verileriOku("select format(sum(alis_fiyati*mevcut_stok),'Currency') as toplam from urun_stok where id<>2").Rows[0][0].ToString();
            baglan.verileriComboListele("select * from urun_grubu", "urun_grup_adi", "urun_grup_id",comboBox2);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            UrunGiris urun_giris = new UrunGiris();
            urun_giris.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
                   
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString());
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_grup_adi"].Value.ToString());
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString());
            textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString());
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["mevcut_stok"].Value.ToString());
            textBox7.Text= Convert.ToString(dataGridView1.CurrentRow.Cells["kdv_orani"].Value.ToString());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,us.satis_fiyati,us.alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and us.urun_adi like'%" + textBox8.Text + "%'", dataGridView1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //baglan.verileriTablodaGoster("select us.barkod,us.urun_adi,ug.urun_grup_adi,us.satis_fiyati,us.alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and ug.urun_grup_adi ='%" + "persil" + "%'", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunGiris urun_giris = new UrunGiris();
            urun_giris.urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            urun_giris.Show();
            urun_giris.txtEskiStok.Visible = true;
            urun_giris.txtYeniStok.Visible= true;
            urun_giris.label9.Visible = true;
            urun_giris.label10.Visible = true;
            urun_giris.label11.Visible = true;
            urun_giris.label12.Visible = true;
            urun_giris.btnGuncelle.Visible = true;
        }
    }
}
