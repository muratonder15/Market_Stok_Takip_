using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Market_Stok_Takip_MRT
{
    class Baglanti
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Belgelerim\GitHub\Market_Stok_Takip_-master\stok_takip_veritabani.mdb");
        public void baglan()
        {
           
            baglanti.Open();
        }

        public void kapat()
        {
            baglanti.Close();
        }

        public void sqlCalistir(string sorgu)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
        }

    }
}
