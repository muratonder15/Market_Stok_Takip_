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
    public partial class ToptanciKayit : Form
    {
        Baglanti baglanti = new Baglanti();
        public int toptanci_id;
        public ToptanciKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Toptancilar toptancilar = (Toptancilar)Application.OpenForms["Toptancilar"];
            baglanti.sqlCalistir("insert into toptancilar (toptanci_adi,sirket_yetkilisi,email,internet_adresi,vergi_dairesi,vergi_no,adres,telefon,notlar,kayit_tarihi,toptanci_alacak) values ('"
            +txtToptanciAdi.Text+"','" + txtSirketYetkilisi.Text + "','" + txtEmail.Text + "','" + txtInternetAdresi.Text + "','" + txtVergiDairesi.Text + "','" + txtVergiNo.Text + "','"
            + txtAdres.Text + "','" + txtTelefon.Text + "','" + txtNotlar.Text + "','"+DateTime.Now+"','"+txtBorc.Text+"')");

            baglanti.verileriTablodaGoster("select toptanci_id,toptanci_adi,format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where toptanci_id<>1", toptancilar.dataGridView1);
            MessageBox.Show("Kayıt başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK);
            this.Hide();
            //foreach (Control item in this.Controls) // textboxları temizle                   
            //{
            //    if (item is TextBox)
            //    {
            //        TextBox tbox = (TextBox)item;
            //        tbox.Clear();
            //    }
            //}
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Toptancilar toptancilar = (Toptancilar)Application.OpenForms["Toptancilar"];
            baglanti.sqlCalistir("update toptancilar set " +
                "toptanci_adi='" +txtToptanciAdi.Text + "',"+
                "sirket_yetkilisi='" + txtSirketYetkilisi.Text + "'," +
                "email='" + txtEmail.Text  +  "'," +
                "internet_adresi='" + txtInternetAdresi.Text + "'," +
                "vergi_dairesi='" + txtVergiDairesi.Text + "'," +
                "vergi_no='" + txtVergiNo.Text + "'," +
                "adres='" + txtAdres.Text + "'," +
                "telefon='" + txtTelefon.Text + "'," +
                "notlar='" + txtNotlar.Text + "'," +
                "toptanci_alacak='" + txtBorc.Text  +"'"+
                " where toptanci_id=" + toptanci_id);
            baglanti.verileriTablodaGoster("select toptanci_id,toptanci_adi,format(toptanci_alacak,'Currency') as toptanci_alacak from toptancilar where toptanci_id<>1", toptancilar.dataGridView1);
            MessageBox.Show("GÜncelleme başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK);
            this.Hide();
        }

        private void ToptanciKayit_Load(object sender, EventArgs e)
        {
            if (toptanci_id != 0) 
            {
                txtToptanciAdi.Text = baglanti.verileriOku("select toptanci_adi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtSirketYetkilisi.Text = baglanti.verileriOku("select sirket_yetkilisi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtEmail.Text = baglanti.verileriOku("select email from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtInternetAdresi.Text = baglanti.verileriOku("select internet_adresi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtVergiDairesi.Text = baglanti.verileriOku("select vergi_dairesi from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtVergiNo.Text = baglanti.verileriOku("select vergi_no from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtAdres.Text = baglanti.verileriOku("select adres from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtTelefon.Text = baglanti.verileriOku("select telefon from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtNotlar.Text = baglanti.verileriOku("select notlar from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
                txtBorc.Text = baglanti.verileriOku("select toptanci_alacak from toptancilar where toptanci_id=" + toptanci_id).Rows[0][0].ToString();
            }
            }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kaydetmeden çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
