using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace NYP_Final_Projesi
{
    public class Veritabani
    {
        public static string connectionstring= "Data Source=MSI;Initial Catalog=NYP Final Projesi;Integrated Security=true";

        private static SqlConnection Baglan()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Kurulamadı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            return con;
        }

        public static bool IslemYap(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Baglan());
            if (com.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public static object FunctionCagir(string sql, int deger)
        {
            SqlCommand com = new SqlCommand(sql, Baglan());
            com.Parameters.Add("@uID", SqlDbType.Int).Value =deger;
            return com.ExecuteScalar();
        }

        public static DataTable TabloSorgula(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Baglan());
            DataTable data = new DataTable();
            adap.Fill(data);
            return data;
        }
        public static void UpdateIslemi(string proseduradi,int mID,decimal ttr,DateTime tarih,int uID,int miktar )
        {
           SqlCommand cmd = new SqlCommand(proseduradi, Baglan());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
            cmd.Parameters.Add("@umik", SqlDbType.Int).Value = miktar;
            cmd.Parameters.Add("@ttr", SqlDbType.Money).Value = ttr;
            cmd.Parameters.Add("@trh", SqlDbType.DateTime).Value = tarih;
            cmd.Parameters.Add("@uID", SqlDbType.Int).Value =uID;
            cmd.ExecuteNonQuery();
        }
        public static void UpdateIslemiMusteri(string proseduradi, int mID, int hmiktari, int Amiktari)
        {
            SqlCommand cmd = new SqlCommand(proseduradi, Baglan());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mID;
            cmd.Parameters.Add("@Hmiktari", SqlDbType.Int).Value = hmiktari;
            cmd.Parameters.Add("@Amiktari", SqlDbType.Int).Value = Amiktari;
            cmd.ExecuteNonQuery();
        }

        public static void YeniMusteriEkle(string proseduradi,string mAdi,string mSoyadi,string mAdresi, int hmiktari, int Amiktari)
        {
            SqlCommand cmd = new SqlCommand(proseduradi, Baglan());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mAdi", SqlDbType.NVarChar).Value = mAdi;
            cmd.Parameters.Add("@mSoyadi", SqlDbType.NVarChar).Value = mSoyadi;
            cmd.Parameters.Add("@mAdresi", SqlDbType.NVarChar).Value =mAdresi;
            cmd.Parameters.Add("@Amiktari", SqlDbType.Int).Value = Amiktari;
            cmd.Parameters.Add("@Hmiktari", SqlDbType.Int).Value = hmiktari;
            cmd.ExecuteNonQuery();
        }
        public static DataRow SatirSorgula(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Baglan());
            DataSet data = new DataSet();
            adap.Fill(data);
            return data.Tables[0].Rows[0];
        }
    }
}

