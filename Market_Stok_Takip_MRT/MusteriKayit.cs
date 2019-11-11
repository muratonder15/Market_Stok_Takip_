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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        Baglanti veritabani = new Baglanti();
        private void MusteriKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //müşteri kayıt butonu
        {
            
            veritabani.sqlCalistir("insert into musteriler (ad_soyad,email,telefon,adres,notlar,kayit_tarihi) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+DateTime.Now +"')");


        }
    }
}
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Belgelerim\GitHub\Market_Stok_Takip_-master\stok_takip_veritabani.mdb