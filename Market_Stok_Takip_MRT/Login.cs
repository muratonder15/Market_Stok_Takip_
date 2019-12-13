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
        int kontrol = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            int kontrol = Convert.ToInt32(baglanti.verileriOku("select count(*) from kullanicilar where kullanici_adi='" + kullanici_adi + "' and kullanici_sifresi='"+sifre+"'").Rows[0][0]);
            if (kontrol > 0)
            {
                AnaMenu anaMenu = new AnaMenu();
                //anaMenu.toolStripButton4.Visible = false;
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adı verya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
