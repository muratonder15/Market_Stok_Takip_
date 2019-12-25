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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        string kullanici_adi;
        string sifre;
        public int kullanici_kodu;
        int kontrol = 0;
        AnaMenu ana_menu = new AnaMenu();
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            int kontrol = Convert.ToInt32(baglanti.verileriOku("select count(*) from kullanicilar where kullanici_adi='" + kullanici_adi + "' and kullanici_sifresi='"+sifre+"'").Rows[0][0]);
            if (kontrol > 0)
            {
                int yetki_kontrol = Convert.ToInt32(baglanti.verileriOku("select kullanici_tip_id from kullanicilar where kullanici_adi='" + kullanici_adi + "' and kullanici_sifresi='" + sifre + "'").Rows[0][0]); ;
                if (yetki_kontrol == 2)
                {
                    //ana_menu.toolStripButton4.Visible = false;                
                    ana_menu.Show();
                    ana_menu.kullanici_kodu = Convert.ToInt32(baglanti.verileriOku("select kullanici_kodu from kullanicilar where kullanici_adi='" + kullanici_adi + "' and kullanici_sifresi='" + sifre + "'").Rows[0][0]);
                    this.Hide();
                }
                else
                {
                    ana_menu.toolStripButton3.Visible = false;
                    ana_menu.toolStripButton4.Visible = false;                
                    ana_menu.Show();
                    ana_menu.kullanici_kodu = Convert.ToInt32(baglanti.verileriOku("select kullanici_kodu from kullanicilar where kullanici_adi='" + kullanici_adi + "' and kullanici_sifresi='" + sifre + "'").Rows[0][0]);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanici adı verya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MailSifreGonder mail_sifre_gonder = new MailSifreGonder();
            mail_sifre_gonder.Show();
        }
    }
}
