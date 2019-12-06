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
    public partial class HizliTusSecimi : Form
    {
        public HizliTusSecimi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        string urun_secimi_id;
        public string hizli_tus_bilgisi;
        private void HizliTusSecimi_Load(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select id,barkod,urun_adi,mevcut_stok from urun_stok where id<>2", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satisİslemi satis_islemi = new Satisİslemi();
            baglanti.sqlCalistir("update hizli_tuslar set durum=true,urun_id="+urun_secimi_id+" where nesne_adi='"+hizli_tus_bilgisi+"'");
            satis_islemi.urun_id =Convert.ToInt32(urun_secimi_id);
            satis_islemi.Show();
            this.Hide();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            urun_secimi_id = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            
        }
    }
}
