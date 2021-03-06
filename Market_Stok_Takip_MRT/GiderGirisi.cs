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
    public partial class GiderGirisi : Form
    {
        public GiderGirisi()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        AnaMenu ana_menu = (AnaMenu)Application.OpenForms["AnaMenu"];
        private void button1_Click(object sender, EventArgs e)
        {
            string aciklama = textBox2.Text;
            baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,odeme_turu_kodu,urun_id,islem_tarihi,toplam_tutar,cari_hesap_adi,islemi_yapan_kullanici_kodu,toptanci_id) values(10,2," + comboBox1.SelectedValue.ToString() + ",2,'" + DateTime.Now + "','" + textBox1.Text + "','" + aciklama + "'," + ana_menu.kullanici_kodu + ",0)");
            MessageBox.Show("gider çıkışı yapıldı", "Başarılı", MessageBoxButtons.OK);
            this.Hide();
        }

        private void GiderGirisi_Load(object sender, EventArgs e)
        {
            baglanti.verileriComboListele("select * from odeme_turleri where odeme_kodu in (1,2,3,4,5)", "odeme_turu", "odeme_kodu", comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Giriş yaptığınız bilgileri kaydetmeden çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
