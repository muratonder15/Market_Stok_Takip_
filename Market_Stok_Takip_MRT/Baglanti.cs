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
            //OleDbDataReader oku = komut.ExecuteReader();
            baglanti.Close();
        }

        public DataTable verileriOku(string sorgu_cumlesi)
        {
            baglanti.Open();
            DataGridView grid = new DataGridView();         
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu_cumlesi, baglanti);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            baglanti.Close();
            return dt;              
                              
        }

        public void verileriTablodaGoster(string sorgu_cumlesi, DataGridView grid)
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu_cumlesi, baglanti);
            DataSet ds= new DataSet();
            da.Fill(ds);
            grid.DataSource=  ds.Tables[0];
            baglanti.Close();

        }
        public void verileriComboListele(string sorgu_cumlesi, string icerik,string id,ComboBox item)
        {    
            baglanti.Open();
            
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu_cumlesi;
            OleDbDataReader oku = komut.ExecuteReader();
            //item.Items.Clear();
            item.DisplayMember = "Text";
            item.ValueMember = "Value";


            var emps = new List<ComboboxItem>();

        
            while (oku.Read())
            {
                emps.Add(new ComboboxItem { Text = oku[icerik].ToString(), Value = oku[id].ToString() });
                
                //item.Items.Add( new ComboboxItem { Text= oku[icerik].ToString(), Value= oku[id].ToString() });
                
            }
            item.DataSource = emps;
            item.SelectedIndex = 0;
            baglanti.Close();

        }
        

    }
}
