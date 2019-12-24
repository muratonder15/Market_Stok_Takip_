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
        public int urun_id;
        public Stoklar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.alis_fiyati,'Currency') as alis_fiyati,format(us.satis_fiyati,'Currency') as satis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and urun_varmi=true", dataGridView1);
            textBox10.Text = baglan.verileriOku("select count(*) from urun_stok where id<>2 and urun_varmi=true").Rows[0][0].ToString();
            textBox9.Text = baglan.verileriOku("select format(sum(alis_fiyati*mevcut_stok),'Currency') as toplam from urun_stok where id<>2 and urun_varmi=true").Rows[0][0].ToString();
            baglan.verileriComboListele("select * from urun_grubu", "urun_grup_adi", "urun_grup_id",comboBox2);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            UrunGiris urun_giris = new UrunGiris();
            urun_giris.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["id"].Value.ToString() != "")
            {
                urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
                textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString());
                textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_grup_adi"].Value.ToString());
                textBox4.Text =  Convert.ToString(dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString());
                textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString());
                textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["mevcut_stok"].Value.ToString());
                textBox7.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["kdv_orani"].Value.ToString());
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.satis_fiyati,'Currency') as satis_fiyati,format(us.alis_fiyati,'Currency') as alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and urun_varmi=true and us.urun_adi like'%" + textBox8.Text + "%'", dataGridView1);
            textBox10.Text = baglan.verileriOku("select count(*) from urun_stok where id<>2 and urun_varmi=true and urun_adi like '%"+textBox8.Text+"%'").Rows[0][0].ToString();
            textBox9.Text = baglan.verileriOku("select format(sum(alis_fiyati*mevcut_stok),'Currency') as toplam from urun_stok where id<>2 and urun_varmi=true and urun_adi like '%" + textBox8.Text + "%'").Rows[0][0].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunGiris urun_giris = new UrunGiris();
            urun_giris.urun_id = urun_id;
            urun_giris.Show();
            urun_giris.txtEskiStok.Visible = true;
            urun_giris.txtYeniStok.Visible= true;
            urun_giris.label9.Visible = true;
            urun_giris.label10.Visible = true;
            urun_giris.label11.Visible = true;
            urun_giris.label12.Visible = true;
            urun_giris.btnGuncelle.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Ürün bilgisini silerseniz stoktaki bütün ürünler silinecek", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglan.sqlCalistir("update urun_stok set urun_varmi=false where id=" + urun_id);
                baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.satis_fiyati,'Currency') as satis_fiyati,format(us.alis_fiyati,'Currency') as alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and urun_varmi=true", dataGridView1);
            }
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.satis_fiyati,'Currency') as satis_fiyati,format(us.alis_fiyati,'Currency') as alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and urun_varmi=true and us.urun_adi like'%" + textBox8.Text + "%' and ug.urun_grup_id=" + comboBox2.SelectedValue.ToString(), dataGridView1);
            textBox10.Text = baglan.verileriOku("select count(*) from urun_stok where id<>2 and urun_varmi=true and urun_adi like '%" + textBox8.Text + "%' and urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
            textBox9.Text = baglan.verileriOku("select format(sum(alis_fiyati*mevcut_stok),'Currency') as toplam from urun_stok where id<>2 and urun_varmi=true and urun_adi like '%" + textBox8.Text + "%' and  urun_grup_id=" + comboBox2.SelectedValue.ToString()).Rows[0][0].ToString();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            baglan.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,format(us.satis_fiyati,'Currency') as satis_fiyati,format(us.alis_fiyati,'Currency') as alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2 and urun_varmi=true and us.urun_adi like'%" + textBox8.Text + "%'  order by us.urun_adi asc", dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sayimİslemi sayim_islemi = new Sayimİslemi();
            sayim_islemi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExceleAktar excel = new ExceleAktar();
            excel.excelExport(dataGridView1);
        }
    }
}
