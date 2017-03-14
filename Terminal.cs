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
    public class Terminal:Dukkan
    {
        public Terminal(KasaGorevlisi a)//aggregation
        {
            this.K_Gorevli = a;
        }
        public int SeriNo { get; set; }
        public KasaGorevlisi K_Gorevli { get; set; }
        
    }
}
