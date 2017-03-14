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
    public class Urun
    {
        public Urun()
        {
            tanim = new UrunTanimi();
        }
        public UrunTanimi tanim { get; set; }
        public int urunID { get; set; }
        public string urunAdi { get; set; }
        public int Stokmiktari { get; set; }
        public int YeniurunID { get; set; }
        public string YeniurunAdi { get; set; }
        public int YeniStokmiktari { get; set; }
        public int SilinicekurunID { get; set; }
        public int StokEklenecekurunID { get; set; }
        public int StokEklenecekadet { get; set; }
    }
}
