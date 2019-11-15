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
    public partial class UrunGiris : Form
    {
        public UrunGiris()
        {
            InitializeComponent();
        }
        
        Baglanti baglanti = new Baglanti();
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {

            baglanti.verileriComboListele("select * from urun_grubu where urun_grup_id<>1","urun_grup_adi","urun_grup_id", cmbUrunGrubu);
            baglanti.verileriComboListele("select * from toptancilar", "toptanci_adi", "toptanci_id", comboBox1);
            baglanti.verileriComboListele("select * from odeme_turleri", "odeme_turu", "odeme_kodu", comboBox2);
            textBox1.Visible = false;
            textBox2.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                txtUrunAdi.Text = baglanti.verileriOku("select top 1 * from urun_stok where urun_grup_id=" + Convert.ToInt32(txtBarkodNo.Text);
            }
        }
    }
}
