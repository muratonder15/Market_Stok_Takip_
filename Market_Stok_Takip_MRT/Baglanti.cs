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
        

        public void sqlCalistir(string sorgu)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();         
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void verileriGoster(string veriler, DataGridView grid)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds= new DataSet();
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];


            
        }

    }
}
