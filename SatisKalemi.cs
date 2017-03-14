using System.Windows.Forms;
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
    public class SatisKalemi
    {
        public SatisKalemi()
        {
            urunler = new Urun();
        }
        public Urun urunler;
        public int Miktar { get; set; }
        public virtual void UrunSat(int x,int y)
        {
           
        }
        public virtual void Urunekle(int ID,string urunAd,double fiyat,int miktar,string aciklama)
        {

        }

    }
}
