using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_Final_Projesi
{
   
    public partial class frmLogin : Form

    {
        SqlCommand cmd;
        SqlConnection con;
        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, System.EventArgs e)
        {
              con = new SqlConnection("Data Source=MSI;Initial Catalog=NYP Final Projesi;Integrated Security=true");
                KasaGorevlisi kg = new KasaGorevlisi();
                con.Open();//bağlantı açıyorum.
            kg.TcKimlikNo = txtkullaniciID.Text;
            kg.G_Sifre = txtSifre.Text;
             cmd = new SqlCommand("Login", con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@kullaniciID", SqlDbType.NVarChar).Value = kg.TcKimlikNo;
            //  2  satırda parametreli procedure parametre gonderiyoruz
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value =kg.G_Sifre ;
            // birden fazla parametre olmasından dolayı sqldatareader kullandım read() komutu true veya false deger donderir bundan dolayı if içerisinde kullandım.
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                this.Hide();
                    frmAna frmAna = new frmAna();
                    frmAna.Show();
                }
                else
                {
                MessageBox.Show("Kullanici Adi veya Sifre yanlış!!");
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //sifre gorunurluk kısmı
            if (chkSfrGstr.Checked == true)
                txtSifre.PasswordChar = char.Parse("\0");
            else
                txtSifre.PasswordChar = char.Parse("*");
        }

        

    }
}
