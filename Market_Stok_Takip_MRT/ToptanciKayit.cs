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
        Baglanti baglan = new Baglanti();
        public ToptanciKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.sqlCalistir("insert into toptancilar (toptanci_adi,sirket_yetkilisi,email,internet_adresi,vergi_dairesi,vergi_no,adres,telefon,notlar,kayit_tarihi) values ('"
            +txtToptanciAdi.Text+"','" + txtSirketYetkilisi.Text + "','" + txtEmail.Text + "','" + txtInternetAdresi.Text + "','" + txtVergiDairesi.Text + "','" + txtVergiNo.Text + "','"
            + txtAdres.Text + "','" + txtTelefon.Text + "','" + txtNotlar.Text + "','"+DateTime.Now+"')");
            MessageBox.Show("Kayıt başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK);

            foreach (Control item in this.Controls) // textboxları temizle                   
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }
    }
}
