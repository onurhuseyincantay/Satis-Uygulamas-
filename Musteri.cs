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
    public  class Musteri
    {
        public int musteriID { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public string adres { get; set; }
        public decimal toplamHarcama { get; set; }
        public int toplamAlisveris { get; set; }
    }
}
