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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select musteri_id,ad_soyad from musteriler where musteri_id<>1", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satisİslemi satis_islemi = (Satisİslemi)Application.OpenForms["Satisİslemi"];          
            satis_islemi.musteri_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_id"].Value);
            satis_islemi.lblMusteriAdi.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            this.Hide();
        }
    }
}
