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
    public partial class VeresiyeDefteri : Form
    {
        public VeresiyeDefteri()
        {
            InitializeComponent();
        }
        public int musteri_id;
        private void VeresiyeDefteri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorcEkleme musteri_borc_ekleme = new MusteriBorcEkleme();
            musteri_borc_ekleme.musteri_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_id"].Value.ToString());
            musteri_borc_ekleme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
