using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Market_Stok_Takip_MRT
{
    public partial class MailSifreGonder : Form
    {
        public MailSifreGonder()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void MailSifreGonder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kayit_kontrol = Convert.ToInt32(baglanti.verileriOku("select count(*) from kullanicilar where email='" + textBox1.Text + "'").Rows[0][0].ToString());
            if (kayit_kontrol>0)
            {
                string kullanici_adi = baglanti.verileriOku("select kullanici_adi from kullanicilar where email='" + textBox1.Text + "'").Rows[0][0].ToString();
                string sifre = baglanti.verileriOku("select kullanici_sifresi from kullanicilar where email='" + textBox1.Text + "'").Rows[0][0].ToString(); ;
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.live.com";
                sc.EnableSsl = true;

                sc.Credentials = new NetworkCredential("sifre_gonderme_hesabi@hotmail.com", "09003101344p");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("sifre_gonderme_hesabi@hotmail.com", "Şifre Gönderme Sistemi");

                mail.To.Add(textBox1.Text);
                //mail.To.Add("alici2@mail.com");

                //mail.CC.Add("alici3@mail.com");
                //mail.CC.Add("alici4@mail.com");

                mail.Subject = "Şifreniz"; mail.IsBodyHtml = true; mail.Body = "Kullanıcı Adınız:"+kullanici_adi+", Şifreniz:"+sifre;

                //mail.Attachments.Add(new Attachment(@"C:\Rapor.xlsx"));
                //mail.Attachments.Add(new Attachment(@"C:\Sonuc.pptx"));

                sc.Send(mail);
                label2.Visible = true;
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "şifreniz e posta adresinize gönderildi.";
            }
            else
            {
                label2.Visible = true;
                label2.Text = "sistemde böyle bir e posta adresi bulunmamaktadır.";
            }
        }
    }
}
