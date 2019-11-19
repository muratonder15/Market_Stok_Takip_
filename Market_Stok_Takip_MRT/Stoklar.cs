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
            baglan.verileriTablodaGoster("select us.barkod,us.urun_adi,ug.urun_grup_adi,us.satis_fiyati,us.alis_fiyati,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id", dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString());
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["urun_grup_adi"].Value.ToString());
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString());
            textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString());
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["mevcut_stok"].Value.ToString());
        }
    }
}
