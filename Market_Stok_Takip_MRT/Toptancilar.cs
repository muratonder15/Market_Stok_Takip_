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
    public partial class Toptancilar : Form
    {
        public Toptancilar()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void Toptancilar_Load(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select * from toptancilar where toptanci_id<>1",dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtToptanciAdi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["toptanci_adi"].Value.ToString());
            txtSirketYetkilisi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["sirket_yetkilisi"].Value.ToString());
            txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value.ToString());
            txtInternetAdresi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["internet_adresi"].Value.ToString());
            txtVergiDairesi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["vergi_dairesi"].Value.ToString());
            txtVergiNo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["vergi_no"].Value.ToString());
            txtAdres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["adres"].Value.ToString());
            txtTelefon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["telefon"].Value.ToString());
            txtNotlar.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["notlar"].Value.ToString());
            txtBorc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["toptanci_alacak"].Value.ToString());
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.verileriTablodaGoster("select * from toptancilar where toptanci_id<>1 and toptanci_adi like'%"+textBox1.Text+"%'", dataGridView1);
        }
    }
}
