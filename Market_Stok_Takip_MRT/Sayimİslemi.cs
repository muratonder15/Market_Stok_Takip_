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
        public int urun_id;
        DataTable tablo = new DataTable();
        Baglanti baglanti = new Baglanti();
        private void Sayimİslemi_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("barkod no", typeof(string));
            tablo.Columns.Add("ürün adı", typeof(string));
            tablo.Columns.Add("sayımda sayılan", typeof(int));
            tablo.Columns.Add("stokta görünen", typeof(int));
            //tablo.Columns.Add("aradaki fark", typeof(int));
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.verileriOku("select count(*) from urun_stok where barkod="+textBox1.Text+" and urun_varmi=true and mevcut_stok>0 ").Rows[0][0].ToString()!="0")
            {
                string id = baglanti.verileriOku("select id from urun_stok where barkod=" + textBox1.Text + " and urun_varmi=true and mevcut_stok>0 ").Rows[0][0].ToString();
                string barkod = baglanti.verileriOku("select barkod from urun_stok where id=" + id).Rows[0][0].ToString();
                string urun_adi = baglanti.verileriOku("select urun_adi from urun_stok where id=" + id).Rows[0][0].ToString();
                textBox2.Text = urun_adi;
                int stok_miktari = Convert.ToInt32(baglanti.verileriOku("select mevcut_stok from urun_stok where id=" + id).Rows[0][0].ToString());
                sayimda_sayilan = Convert.ToInt32(textBox3.Text);

                tablo.Rows.Add(barkod, urun_adi, sayimda_sayilan, stok_miktari);
                dataGridView1.DataSource = tablo;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunListesi urun_listesi = new UrunListesi();
            urun_listesi.button2.Visible = true;
            urun_listesi.button1.Visible = false;
            urun_listesi.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            DataTable sayim_tablo = new DataTable();           
            sayim_tablo.Columns.Add("urun adı", typeof(string));
            sayim_tablo.Columns.Add("sayılan toplam", typeof(string));

            int[] urun_sayim = new int[1000];
            string[] urun_adi_dizi = new string[1000];
            for (int m = 0; m < 1000; m++)
            {
                urun_sayim[m] = 0;
            }

            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
            {
                
                
                for (int j = 0; j <= dataGridView1.Rows.Count - 2; j++)
                {
                    
                        if (dataGridView1.Rows[i].Cells[0].Value == dataGridView1.Rows[j].Cells[0].Value)
                        {
                        urun_sayim[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)] = urun_sayim[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)] + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
   
                        urun_adi_dizi[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                           
                        }
                    
                
                }
                

            }
            for (int k = 0; k < 1000; k++)
            {
                if (urun_sayim[k] != 0)
                {

                    //sayim_tablo.Rows.Add(dataGridView1.Rows[i].Cells[1].Value.ToString(), sayim_top.ToString());                   

                    //listBox1.Items.Add(sayim_tablo.Rows[i][0].ToString()+"="+ sayim_tablo.Rows[i][1].ToString());
                    string mevcut_stok= baglanti.verileriOku("select mevcut_stok from urun_stok where urun_varmi=true and barkod="+k.ToString()).Rows[0][0].ToString();
                    sayim_tablo.Rows.Add(urun_adi_dizi[k].ToString(), urun_sayim[k].ToString());

                    //listBox1.Items.Add(urun_adi_dizi[k].ToString() + "=" + urun_sayim[k].ToString()+"-->"+mevcut_stok);

                    listBox1.Items.Add(urun_adi_dizi[k].ToString());
                    listBox2.Items.Add(urun_sayim[k].ToString());
                    listBox3.Items.Add(mevcut_stok);

                }
            }

            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }
    }
}
