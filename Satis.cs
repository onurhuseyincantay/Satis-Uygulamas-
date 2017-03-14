using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NYP_Final_Projesi

{
    public class Satis:SatisKalemi
    {
        public DateTime KayitTarihi { get; set; }
        public decimal tutar { get; set; }
        public override void UrunSat(int adet, int Id)
        {
            base.UrunSat(adet, Id);
            SqlConnection con = new SqlConnection(Veritabani.connectionstring);
            con.Open();
            SqlCommand com = new SqlCommand("Update tblurunler set stokMiktari=stokMiktari-" +adet.ToString()+"where urunID=" +Id.ToString(),con);
            com.ExecuteNonQuery();
            con.Close();
        }
        

    }
}
