using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NYP_Final_Projesi
{
    public partial class frmAna : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            /*
             2 adet form ekranı olması dolayasıyıla ve gizle one getir metoduyla çalıştıgım için 
             2 form un kapatma butonu ile kapatılması otomasyonun kapatıldığı anlamına gelmiyordu bende menuye 
            1 adet programı kapat butonu ekleyip çarpı butonunu bu metotla iptal ettim.
                 */
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
      
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=NYP Final Projesi;Integrated Security=true");
        SqlCommand cmd;
        Dukkan d1 = new Dukkan();
        Musteri musteri = new Musteri();
        Satis st = new Satis();
        SatisKalemi sk = new SatisKalemi();
        UrunKatalogu uk = new UrunKatalogu();
        public frmAna()
        {
            InitializeComponent();
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            //burada aranabilir bir combo box yaptım..
            cmbxUrunCikar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbxUrunCikar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbxurunstokEkleme.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbxurunstokEkleme.AutoCompleteSource = AutoCompleteSource.CustomSource;
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            //groubox gorunurluk kısmı
            grpbxMusteriKayitlari.Visible = false;
            grpbxUrunKatalogu.Visible = false;
            grpbxUrunler.Visible = false;
            grpbxSatisKalemi.Visible = false;
            grpbxHesapDefteri.Visible = false;
        }
        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            grpbxUrunler.Visible = true;
            grpbxMusteriKayitlari.Visible = false;
            grpbxSatisKalemi.Visible = false;
            grpbxUrunKatalogu.Visible = false;
            grpbxHesapDefteri.Visible = false;
        }
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            grpbxUrunler.Visible = false;
            grpbxMusteriKayitlari.Visible = false;
            grpbxSatisKalemi.Visible = false;
            grpbxUrunKatalogu.Visible = false;
            grpbxHesapDefteri.Visible = false;
        }
        private void musteriKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            grpbxUrunler.Visible = false;
            grpbxMusteriKayitlari.Visible = true;
            grpbxSatisKalemi.Visible = false;
            grpbxUrunKatalogu.Visible = false;
            grpbxHesapDefteri.Visible = false;
        }
        private void urunKataloguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            lblUrunIDSil.Text = "Ürün ID :";
            txturunAdEkle.Text = "";
            txtUrunFiyatEkle.Text = "";
            txtUrunIDEkle.Text = "";
            txtUrunMiktarEkle.Text = "";
            txturunAciklamasi.Text = "";
            txtUrunStokmiktariekleme.Text = "";
            grpbxUrunler.Visible = false;
            grpbxMusteriKayitlari.Visible = false;
            grpbxSatisKalemi.Visible = false;
            grpbxUrunKatalogu.Visible = true;
            grpbxHesapDefteri.Visible = false;
        }
        private void hesapDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            grpbxUrunler.Visible = false;
            grpbxMusteriKayitlari.Visible = false;
            grpbxSatisKalemi.Visible = false;
            grpbxUrunKatalogu.Visible = false;
            grpbxHesapDefteri.Visible = true;
        }
        private void satisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
            MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
            HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
            txtadt1.Text = "";
            txtmusteriBilgileri.Text = "";
            lblUcret2.Text = "Ücret :";
            lblUcret.Text = "Ücret :";
            txtmusteriAdiSatis.Text = "";
            txtMusteriSoyadiSatis.Text = "";
            txtmusteriAdresi.Text = "";
            txtAdt2.Text = "";
            grpbxUrunler.Visible = false;
            grpbxMusteriKayitlari.Visible = false;
            grpbxSatisKalemi.Visible = true;
            grpbxUrunKatalogu.Visible = false;
            grpbxHesapDefteri.Visible = false;
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Hide();
            log.Show();
        }
        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        private void urunSec_Click(object sender, EventArgs e)
        {
            if (txturunSecimi.Text != "")
            {
                con.Open();
                SqlCommand com = new SqlCommand("select * from tblurunler where urunID=" + txturunSecimi.Text, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    sk.urunler.urunID = Convert.ToInt16(dr["urunID"]);
                    sk.urunler.Stokmiktari = Convert.ToInt16(dr["stokMiktari"]);
                    sk.urunler.tanim.fiyat = Convert.ToInt16(dr["fiyat"]);
                }
                if (sk.urunler.urunID == 0)
                    MessageBox.Show("Girmiş oldugunuz Ürün ID'si bulunmamaktadir");
                con.Close();
                if (sk.urunler.urunID != 0)
                {
                    grpbxUrunler.Visible = false;
                    grpbxMusteriKayitlari.Visible = true;
                    grpbxSatisKalemi.Visible = false;
                    grpbxUrunKatalogu.Visible = false;
                    grpbxHesapDefteri.Visible = false;
                }
            }
            else
                MessageBox.Show("Ürün Seçimi Gerçekleştiriniz!!!");
                
        }
        private void txtAdArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
               /*try kullanmamın sebebi arama yapıldıktan sonra text i silince null a donusuyor ve 
               convert kullandıgım için null hata veriyor bunun ustesinden gelebilmek için*/
               urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler where urunAd like '" + txtAdArama.Text + "%'");
            }
            catch
            {
            }
        }
        private void txtIDarama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler where urunID like '" + Convert.ToInt16(txtIDarama.Text) + "%'");
            }
            catch
            {

            }
        }
        private void txtmusteriAdArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri where musteriAd like '" + txtAdArama.Text + "%'");

            }
            catch
            {
            }
        }
        private void txtmusteriIDArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri where musteriID like '" + Convert.ToInt16(txtmusteriIDArama.Text) + "%'");
            }
            catch 
            {
            }
        }
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (sk.urunler.urunID != 0)
            {
                if (txtmusteriIDsecimi.Text != "")
                {
                    musteri.musteriID = Convert.ToInt16(txtmusteriIDsecimi.Text);
                    con.Open();
                    SqlCommand com = new SqlCommand("select * from Musteri where musteriID=" + Convert.ToString(musteri.musteriID), con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        musteri.musteriAdi = dr["musteriAdi"].ToString();
                        musteri.musteriSoyadi = dr["musteriSoyadi"].ToString();
                        musteri.adres = dr["musteriAdresi"].ToString();
                        musteri.toplamHarcama = Convert.ToInt16(dr["harcamaMiktari"]);
                        musteri.toplamAlisveris = Convert.ToInt16(dr["alisverisMiktari"]);
                        //burada var olan musterinin bilgileri veritabanından cekilip satıs ekranındaki textbox a gonderiliyor
                        txtmusteriBilgileri.Text = "Musteri Adı:" + musteri.musteriAdi + Environment.NewLine + "Musteri Soyadi:" + musteri.musteriSoyadi + Environment.NewLine
                            + "Musteri Adresi :" + musteri.adres;
                    }
                    con.Close();
                    grpbxUrunler.Visible = false;
                    grpbxMusteriKayitlari.Visible = false;
                    grpbxSatisKalemi.Visible = true;
                    grpbxUrunKatalogu.Visible = false;
                    grpbxHesapDefteri.Visible = false;
                }
                else
                {
                    grpbxUrunler.Visible = false;
                    grpbxMusteriKayitlari.Visible = false;
                    grpbxSatisKalemi.Visible = true;
                    grpbxUrunKatalogu.Visible = false;
                    grpbxHesapDefteri.Visible = false;
                }
            }
            else
                MessageBox.Show("Ürün Seçimi Gerçekleştiriniz!!");
        }
        private void btnUcretHesapla1_Click(object sender, EventArgs e)
        {
            if(musteri.musteriID!=0)
            {
                if (sk.urunler.urunID != 0)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("select * from tblurunler where urunID=" + Convert.ToString(sk.urunler.urunID), con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        //burada var olan musterinin bilgileri veritabanından cekilip satıs ekranındaki textbox a gonderiliyor
                        sk.urunler.urunAdi = dr["urunAd"].ToString();
                        sk.urunler.tanim.fiyat = Convert.ToDecimal(dr["fiyat"]);
                        sk.urunler.tanim.urunAciklamasi = dr["aciklama"].ToString();
                        sk.urunler.Stokmiktari = Convert.ToInt16(dr["stokMiktari"]);
                    }
                    con.Close();
                    st.Miktar = Convert.ToInt16(txtadt1.Text);
                    if (sk.urunler.Stokmiktari >= st.Miktar)
                    {
                        musteri.toplamAlisveris += st.Miktar;
                        st.KayitTarihi = DateTime.Now;
                        st.tutar = st.Miktar * sk.urunler.tanim.fiyat;
                        musteri.toplamHarcama += st.tutar;
                        lblUcret.Text += st.tutar.ToString();
                        st.UrunSat(st.Miktar, sk.urunler.urunID);
                        Veritabani.UpdateIslemi("SatisEkleme", musteri.musteriID, st.tutar, st.KayitTarihi, sk.urunler.urunID, st.Miktar);
                        st.UrunSat(st.Miktar, st.urunler.urunID);
                        Veritabani.UpdateIslemiMusteri("MusteribilgisiDuzenleme", musteri.musteriID, Convert.ToInt16(musteri.toplamHarcama), musteri.toplamAlisveris);
                        con.Open();
                        SqlCommand com2 = new SqlCommand("SELECT Sum(harcamaMiktari)AS 'toplam' FROM Musteri", con);
                        SqlDataReader dr2 = com2.ExecuteReader();
                        while (dr2.Read())
                        {
                            d1.HarcamaMiktari = Convert.ToInt16(dr2["toplam"]);
                        }
                        con.Close();
                        con.Open();
                        SqlCommand com1 = new SqlCommand("SELECT Sum(alisverisMiktari)AS 'toplam' FROM Musteri", con);
                        SqlDataReader dr1 = com1.ExecuteReader();
                        while (dr1.Read())
                        {
                            d1.alisverisMiktari = Convert.ToInt16(dr1["toplam"]);
                        }
                        con.Close();
                        //burada sıkıntı varrr
                        lblSatisMiktari1.Text = Convert.ToString(d1.alisverisMiktari);
                        lblSatisTutari2.Text = Convert.ToString(d1.HarcamaMiktari);
                        //her seferinde hesap defteri view'ini tekrar yenilesin
                        HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
                    }
                    else
                        MessageBox.Show("Girmiş Oldugunuz Miktarda Ürün Stokta Bulunmamaktadir.");
                }
                else
                    MessageBox.Show("Ürün Seçimi Gerçekleştiriniz!!");
            }
            else
                MessageBox.Show("Müşteri Seçimi Gerçekleştiriniz!!");
        }

        private void btnUcretHesapla2_Click(object sender, EventArgs e)
        {
            if (sk.urunler.urunID != 0)
            {
                musteri.musteriAdi = txtmusteriAdiSatis.Text;
                musteri.musteriSoyadi = txtMusteriSoyadiSatis.Text;
                musteri.adres = txtmusteriAdresi.Text;
                st.Miktar = Convert.ToInt16(txtAdt2.Text);
                if (sk.urunler.Stokmiktari >= st.Miktar)
                {
                    st.tutar = st.Miktar * sk.urunler.tanim.fiyat;
                    musteri.toplamHarcama += st.tutar;
                    musteri.toplamAlisveris = Convert.ToInt16(st.Miktar);
                    st.KayitTarihi = DateTime.Now;
                    lblUcret2.Text += st.tutar.ToString();

                    Veritabani.YeniMusteriEkle("MusteriEkle", musteri.musteriAdi, musteri.musteriSoyadi, musteri.adres, Convert.ToInt16(musteri.toplamHarcama), Convert.ToInt16(musteri.toplamAlisveris));
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM Musteri where musteriID=(select max(musteriID) from Musteri)", con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        musteri.musteriID = Convert.ToInt16(dr["musteriID"]);
                    }
                    con.Close();
                    st.UrunSat(st.Miktar, sk.urunler.urunID);
                    Veritabani.UpdateIslemi("SatisEkleme", musteri.musteriID, st.tutar, st.KayitTarihi, sk.urunler.urunID, st.Miktar);
                    HsapDefteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from HesapDefteri");
                    con.Open();
                    SqlCommand com2 = new SqlCommand("SELECT Sum(harcamaMiktari)AS 'toplam' FROM Musteri", con);
                    SqlDataReader dr2 = com2.ExecuteReader();
                    while (dr2.Read())
                    {
                        d1.HarcamaMiktari = Convert.ToInt16(dr2["toplam"]);
                    }
                    con.Close();
                    con.Open();
                    SqlCommand com1 = new SqlCommand("SELECT Sum(alisverisMiktari)AS 'toplam' FROM Musteri", con);
                    SqlDataReader dr3 = com1.ExecuteReader();
                    while (dr3.Read())
                    {
                        d1.alisverisMiktari = Convert.ToInt16(dr3["toplam"]);
                    }
                    con.Close();

                    lblSatisMiktari1.Text = Convert.ToString(d1.alisverisMiktari);
                    lblSatisTutari2.Text = Convert.ToString(d1.HarcamaMiktari);
                    MusteriTablosu.DataSource = Veritabani.TabloSorgula("Select * from Musteri");
                }
                else
                    MessageBox.Show("Girmiş Oldugunuz Miktarda Ürün Stokta Bulunmamaktadir.");
            }
            else
                MessageBox.Show("Ürün Seçimi Gerçekleştiriniz!!");
            }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            
                sk.urunler.YeniurunID = Convert.ToInt16(txtUrunIDEkle.Text);
            sk.urunler.urunAdi = txturunAdEkle.Text;
            sk.urunler.YeniStokmiktari = Convert.ToInt16(txtUrunMiktarEkle.Text);
            sk.urunler.tanim.Yenifiyat = Convert.ToDecimal(txtUrunFiyatEkle.Text);
            sk.urunler.tanim.YeniurunAciklamasi = txturunAciklamasi.Text;
            if (sk.urunler.YeniurunAdi != "" && sk.urunler.YeniurunID != 0 && sk.urunler.YeniStokmiktari != 0 && sk.urunler.tanim.Yenifiyat != 0 && sk.urunler.tanim.YeniurunAciklamasi != "")
            {
                uk.Urunekle(sk.urunler.YeniurunID, sk.urunler.urunAdi, Convert.ToDouble(sk.urunler.tanim.Yenifiyat), sk.urunler.YeniStokmiktari, sk.urunler.tanim.YeniurunAciklamasi);
            }
                else
                    MessageBox.Show("Lutfen Bilgileri tam doldurunuz!!");
            urunlerTablosu.DataSource = Veritabani.TabloSorgula("Select * from tblurunler");
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            if(cmbxUrunCikar.Text!="")
            {
                uk.UrunSil(sk.urunler.SilinicekurunID);
                MessageBox.Show("Ürün Başariyla Silinmiştir");
            }
            else
                MessageBox.Show("Ürün Seçiniz !!!");
        }

        private void cmbxUrunCikar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUrunIDSil.Text = "Ürün ID:";
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM tblurunler where urunAd=" + "'" + cmbxUrunCikar.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                sk.urunler.SilinicekurunID = Convert.ToInt16(dr["urunID"]);
            }
            con.Close();
            lblUrunIDSil.Text += sk.urunler.SilinicekurunID.ToString();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
        }

        private void cmbxurunstokEkleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM tblurunler where urunAd=" + "'" + cmbxurunstokEkleme.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                sk.urunler.StokEklenecekurunID = Convert.ToInt16(dr["urunID"]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                cmbxUrunCikar.Items.Add(DR[0]);
            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("select urunAd from tblurunler", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmbxurunstokEkleme.Items.Add(dr2[0]);
            }
            con.Close();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            if (sk.urunler.StokEklenecekurunID != 0)
            {
                sk.urunler.StokEklenecekadet = Convert.ToInt16(txtUrunStokmiktariekleme.Text);
                uk.UrunStokEkle(sk.urunler.StokEklenecekurunID, sk.urunler.StokEklenecekadet);
                MessageBox.Show("Ürün Stokmiktari Güncellendi!!");
            }
            else
                MessageBox.Show("Ürün Seçiniz !!!");
        }
    }
}
