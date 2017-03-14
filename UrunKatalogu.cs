using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Final_Projesi
{
    public class UrunKatalogu
    {
        public  void Urunekle(int ID, string urunAd, double fiyat, int miktar, string aciklama)
        {
            try
            {
                SqlConnection con = new SqlConnection(Veritabani.connectionstring);
                con.Open();
                SqlCommand com = new SqlCommand("UrunEkle", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@Id", SqlDbType.Int).Value = ID;
                com.Parameters.Add("@urunad", SqlDbType.VarChar).Value = urunAd;
                com.Parameters.Add("@fiyat", SqlDbType.Float).Value = fiyat;
                com.Parameters.Add("@smiktari", SqlDbType.Int).Value = miktar;
                com.Parameters.Add("@aciklama", SqlDbType.NVarChar).Value = aciklama;
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(urunAd + "İsimli" + "Ürününüz Veritabanına Kaydedilmistir.");
            }
            catch
            {
                MessageBox.Show("Lutfen Var Olan UrunID Ataması Yapmaya Çalışmayın");
            }
       }
        public void UrunSil(int ID)
        {
            SqlConnection con = new SqlConnection(Veritabani.connectionstring);
            con.Open();
            SqlCommand com = new SqlCommand("UrunSil", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@urunID", SqlDbType.Int).Value = ID;
            com.ExecuteNonQuery();
            con.Close();
        }
        public void UrunStokEkle(int ID, int adet)
        {
            SqlConnection con = new SqlConnection(Veritabani.connectionstring);
            con.Open();
            SqlCommand com = new SqlCommand("UrunStokEkle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            com.Parameters.Add("@adet", SqlDbType.Int).Value = adet;
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}
