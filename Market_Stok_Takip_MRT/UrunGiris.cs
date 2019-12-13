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
using Microsoft.VisualBasic;
namespace Market_Stok_Takip_MRT
{
    public partial class UrunGiris : Form
    {
        public UrunGiris()
        {
            InitializeComponent();
        }
        public int urun_id;
        Baglanti baglanti = new Baglanti();
        private void button2_Click(object sender, EventArgs e)
        {
            string grup_adi= Interaction.InputBox("Ürün Grubu Giriniz ", "Bilgi Girişi", "", 0, 0);
            baglanti.sqlCalistir("insert into urun_grubu (urun_grup_adi) values('"+grup_adi+"')");
            
            baglanti.verileriComboListele("select * from urun_grubu", "urun_grup_adi", "urun_grup_id", cmbUrunGrubu);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {

            baglanti.verileriComboListele("select * from urun_grubu","urun_grup_adi","urun_grup_id", cmbUrunGrubu);
            baglanti.verileriComboListele("select * from toptancilar", "toptanci_adi", "toptanci_id", cmbToptanci);
            baglanti.verileriComboListele("select * from odeme_turleri", "odeme_turu", "odeme_kodu", cmbOdemeTurleri);
            baglanti.verileriComboListele("select * from olcu_birimleri", "olcu_birimi", "olcu_birimi_id", cmbOlcuBirimi);

            txtEskiStok.Visible = false;
            txtYeniStok.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            if (urun_id.ToString()!="0")
            {
                DataTable table = new DataTable();
                
                table = baglanti.verileriOku("select top 1 * from urun_stok where id=" + urun_id);
                
                    txtBarkodNo.Text= Convert.ToString(table.Rows[0][1]); 
                    txtUrunAdi.Text = Convert.ToString(table.Rows[0][2]);
                    cmbUrunGrubu.SelectedValue = table.Rows[0][3].ToString();
                    txtAlisFiyati.Text = Convert.ToString(table.Rows[0][4]);
                    txtSatisFiyati.Text = Convert.ToString(table.Rows[0][5]);
                    txtKdvOrani.Text = Convert.ToString(table.Rows[0][6]);
                    txtEskiStok.Text = Convert.ToString(table.Rows[0][7]);
                    cmbOlcuBirimi.SelectedValue = table.Rows[0][8].ToString();
                    cmbToptanci.SelectedValue = table.Rows[0][9].ToString();
                 
                   

                
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "" || txtUrunAdi.Text == "" || txtAlisFiyati.Text == "" || txtSatisFiyati.Text == "" || txtKdvOrani.Text == "" || txtStokMiktari.Text == "")
            {

                MessageBox.Show("Boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (baglanti.verileriOku("select * from urun_stok where barkod="+Convert.ToInt32(txtBarkodNo.Text)).Rows.Count>0)
            {
                MessageBox.Show("Girilen barkod numarası sistemde kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                             
                baglanti.sqlCalistir
                    ("insert into urun_stok (barkod,urun_adi,urun_grup_id,alis_fiyati,satis_fiyati,kdv_orani,mevcut_stok,olcu_birimi_id,toptanci_id,odeme_turu_id) values("
                    + Convert.ToInt32(txtBarkodNo.Text) + ",'" + txtUrunAdi.Text + "'," + Convert.ToInt32(cmbUrunGrubu.SelectedValue) + "," + Convert.ToInt32(txtAlisFiyati.Text) + ","
                    + Convert.ToInt32(txtSatisFiyati.Text) + "," + Convert.ToInt32(txtKdvOrani.Text) + "," + Convert.ToInt32(txtStokMiktari.Text) + ","
                    + Convert.ToInt32(cmbOlcuBirimi.SelectedValue) + "," + Convert.ToInt32(cmbToptanci.SelectedValue) + "," + Convert.ToInt32(cmbOdemeTurleri.SelectedValue) + ")");
                
                urun_id = Convert.ToInt32(baglanti.verileriOku("select id from urun_stok where barkod="+txtBarkodNo.Text).Rows[0][0]);
                
                baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,islem_tarihi,barkod,urun_id,alis_fiyati," +
                    "satis_fiyati,miktar,kar,kdv_orani,odeme_turu_kodu,toplam_tutar,islemi_yapan_kullanici_kodu,musteri_id,toptanci_id)" +
                    "values(6,2,'"+DateTime.Now+"',"+ Convert.ToInt32(txtBarkodNo.Text)+","+urun_id+","+ Convert.ToInt32(txtAlisFiyati.Text)+","+ Convert.ToInt32(txtSatisFiyati.Text)+","
                    +Convert.ToInt32(txtStokMiktari.Text)+","+ (Convert.ToInt32(txtSatisFiyati.Text)- Convert.ToInt32(txtAlisFiyati.Text))+","+ Convert.ToInt32(txtKdvOrani.Text)+","
                   + Convert.ToInt32(cmbOdemeTurleri.SelectedValue)+","+ (Convert.ToInt32(txtAlisFiyati.Text)* Convert.ToInt32(txtStokMiktari.Text))+","
                    + "1,1,"+ Convert.ToInt32(cmbToptanci.SelectedValue)+")"
                   );
                MessageBox.Show("Kayıt başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK);
                Stoklar stoklar = (Stoklar)Application.OpenForms["Stoklar"];
                //baglanti.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,us.satis_fiyati,us.alis_fiyati,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2", stoklar.dataGridView1);


                foreach (Control item in this.Controls) // textboxları temizle                   
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }
                cmbUrunGrubu.SelectedIndex = 0;
                cmbOlcuBirimi.SelectedIndex = 0;
                cmbToptanci.SelectedIndex = 0;
                cmbOdemeTurleri.SelectedIndex = 0;
                
                    
            }
        }

        private void txtBarkodNo_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable table = new DataTable();           
            
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkodNo.Text;
                table = baglanti.verileriOku("select top 1 * from urun_stok where barkod=" + barkod);
                try
                {
                    
                    txtUrunAdi.Text = Convert.ToString(table.Rows[0][2]);                    
                    cmbUrunGrubu.SelectedIndex= Convert.ToInt32(table.Rows[0][3]);
                    txtAlisFiyati.Text= Convert.ToString(table.Rows[0][4]);
                    txtSatisFiyati.Text = Convert.ToString(table.Rows[0][5]);
                    txtKdvOrani.Text = Convert.ToString(table.Rows[0][6]);
                    txtEskiStok.Text= Convert.ToString(table.Rows[0][7]);
                    cmbOlcuBirimi.SelectedValue = Convert.ToInt32(table.Rows[0][8]);
                    cmbToptanci.SelectedValue = Convert.ToInt32(table.Rows[0][9]);
                    txtBarkodNo.Clear();
                    txtBarkodNo.Text = barkod;

                }
                catch
                {
                    txtBarkodNo.Clear();
                    txtAlisFiyati.Clear();
                    txtSatisFiyati.Clear();
                    txtUrunAdi.Clear();
                    txtKdvOrani.Clear();
                    txtEskiStok.Clear();
                    
                    txtBarkodNo.Text = barkod;


                }
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || txtBarkodNo.Text.Trim()== "")
            {
                txtBarkodNo.Clear();
            }
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKdvOrani_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStokMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBarkodVer_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = baglanti.verileriOku("select max(barkod) from urun_stok");
            txtBarkodNo.Text = Convert.ToString(Convert.ToInt32(table.Rows[0][0])+1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (urun_id.ToString() != "0")
            {
                txtYeniStok.Text = (Convert.ToInt32(txtStokMiktari.Text) + Convert.ToInt32(txtEskiStok.Text)).ToString();
                baglanti.sqlCalistir("update urun_stok set urun_adi='" + txtUrunAdi.Text + "',urun_grup_id=" + Convert.ToInt32(cmbUrunGrubu.SelectedValue) + ",alis_fiyati=" + Convert.ToInt32(txtAlisFiyati.Text)
                    + ",satis_fiyati=" + Convert.ToInt32(txtSatisFiyati.Text) + ",kdv_orani=" + Convert.ToInt32(txtKdvOrani.Text) + ",mevcut_stok=" + Convert.ToUInt32(txtYeniStok.Text)
                    + ",olcu_birimi_id=" + Convert.ToInt32(cmbOlcuBirimi.SelectedValue) + ",toptanci_id=" + Convert.ToInt32(cmbToptanci.SelectedValue) + ",odeme_turu_id=" + Convert.ToInt32(cmbOdemeTurleri.SelectedValue)
                    + " where id=" + urun_id
                    );

                urun_id = Convert.ToInt32(baglanti.verileriOku("select id from urun_stok where barkod=" + txtBarkodNo.Text).Rows[0][0]);

                baglanti.sqlCalistir("insert into hareketler (hareket_turu_kodu,islem_turu_kodu,islem_tarihi,barkod,urun_id,alis_fiyati," +
                    "satis_fiyati,miktar,kar,kdv_orani,odeme_turu_kodu,toplam_tutar,islemi_yapan_kullanici_kodu,musteri_id,toptanci_id)" +
                    "values(6,2,'" + DateTime.Now + "'," + Convert.ToInt32(txtBarkodNo.Text) + "," + urun_id + "," + Convert.ToInt32(txtAlisFiyati.Text) + "," + Convert.ToInt32(txtSatisFiyati.Text) + ","
                    + Convert.ToInt32(txtStokMiktari.Text) + "," + (Convert.ToInt32(txtSatisFiyati.Text) - Convert.ToInt32(txtAlisFiyati.Text)) + "," + Convert.ToInt32(txtKdvOrani.Text) + ","
                   + Convert.ToInt32(cmbOdemeTurleri.SelectedValue) + "," + (Convert.ToInt32(txtAlisFiyati.Text) * Convert.ToInt32(txtStokMiktari.Text)) + ","
                    + "1,1," + Convert.ToInt32(cmbToptanci.SelectedValue) + ")"
                   );
                MessageBox.Show("Güncelleme başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK);
                Stoklar stoklar = (Stoklar)Application.OpenForms["Stoklar"];
                baglanti.verileriTablodaGoster("select us.id,us.barkod,us.urun_adi,ug.urun_grup_adi,us.satis_fiyati,us.alis_fiyati,us.kdv_orani,us.mevcut_stok from urun_stok us inner join urun_grubu ug on us.urun_grup_id=ug.urun_grup_id where us.id<>2", stoklar.dataGridView1);
            }
        }

        private void txtStokMiktari_TextChanged(object sender, EventArgs e)
        {
            //txtYeniStok.Text =  (Convert.ToInt32(txtStokMiktari.Text) + Convert.ToInt32(txtEskiStok.Text)).ToString();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
