﻿using System;
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
    public partial class Musteriler : Form
    {
        Baglanti baglan = new Baglanti();
        public Musteriler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            
            baglan.verileriTablodaGoster("select * from musteriler", dataGridView1);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString());
           textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value.ToString());
           textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["telefon"].Value.ToString());
           textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["adres"].Value.ToString());
           textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["notlar"].Value.ToString());
           textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["kayit_tarihi"].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
        }
    }
}
