using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Market_Stok_Takip_MRT
{
    class Baglanti
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Belgelerim\\GitHub\\Market_Stok_Takip_-master\\stok_takip_veritabani.mdb");
        
        
        public void sqlCalistir(string sorgu_cumlesi)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();         
            komut.Connection = baglanti;
            komut.CommandText = sorgu_cumlesi;
            komut.ExecuteNonQuery();
            OleDbDataReader oku = komut.ExecuteReader();
            baglanti.Close();
        }

        public OleDbDataReader verileriOku(string sorgu_cumlesi)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu_cumlesi;
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu_cumlesi, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OleDbDataReader oku = komut.ExecuteReader();
            if (!oku.IsDBNull()) { }
            while (oku.Read())
            {
                return oku;
            }
            
        }

        public void verileriTablodaGoster(string sorgu_cumlesi, DataGridView grid)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu_cumlesi, baglanti);
            DataSet ds= new DataSet();
            da.Fill(ds);
            grid.DataSource=  ds.Tables[0];
         
        }
        public void verileriComboListele(string sorgu_cumlesi, string icerik,string id,ComboBox item)
        {    
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu_cumlesi;
            OleDbDataReader oku = komut.ExecuteReader();
            item.Items.Clear();
            item.DisplayMember = "Text";
            item.ValueMember = "Value";
            while (oku.Read())
            {
                item.Items.Add( new  {Text= oku[icerik], Value= oku[id] });
            }
            baglanti.Close();

        }
        

    }
}
