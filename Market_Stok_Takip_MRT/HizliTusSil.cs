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
    public partial class HizliTusSil : Form
    {
        public HizliTusSil()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void HizliTusSil_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button1.Text'").Rows[0][0]) != 0)
            {
                button1.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button1.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button2.Text'").Rows[0][0]) != 0)
            {
                button2.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button2.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button3.Text'").Rows[0][0]) != 0)

            {
                button3.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button3.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button4.Text'").Rows[0][0]) != 0)
            {
                button4.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button4.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button5.Text'").Rows[0][0]) != 0)
            {
                button5.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button5.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button6.Text'").Rows[0][0]) != 0)
            {
                button6.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button6.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button7.Text'").Rows[0][0]) != 0)
            {
                button7.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button7.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button8.Text'").Rows[0][0]) != 0)
            {
                button8.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button8.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button9.Text'").Rows[0][0]) != 0)
            {
                button9.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button9.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button10.Text'").Rows[0][0]) != 0)
            {
                button10.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button10.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button11.Text'").Rows[0][0]) != 0)
            {
                button11.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button11.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button12.Text'").Rows[0][0]) != 0)
            {
                button12.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button12.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button13.Text'").Rows[0][0]) != 0)
            {
                button13.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button13.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button14.Text'").Rows[0][0]) != 0)
            {
                button14.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button14.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button15.Text'").Rows[0][0]) != 0)
            {
                button15.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button15.Text' and ht.durum=true").Rows[0][1].ToString();
            }

            if (Convert.ToInt32(baglanti.verileriOku("select count(*) from hizli_tuslar where durum=true and nesne_adi='button16.Text'").Rows[0][0]) != 0)
            {
                button16.Text = baglanti.verileriOku("select us.id,us.urun_adi,ht.nesne_adi,ht.durum from hizli_tuslar ht inner join urun_stok us on ht.urun_id=us.id where ht.nesne_adi='button16.Text' and ht.durum=true").Rows[0][1].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button1.Text'");
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button2.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button3.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button4.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button5.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button6.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button7.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button8.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button9.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button10.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button11.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button12.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button13.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button14.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button15.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button1.Text != "HIZLI TUŞ ATA")
            {
                baglanti.sqlCalistir("update hizli_tuslar set durum=false where nesne_adi='button16.Text'" );
                Satisİslemi satis_islemi = new Satisİslemi();
                satis_islemi.Show();
                this.Hide();
            }
        }
    }
}
