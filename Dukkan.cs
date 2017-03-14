using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NYP_Final_Projesi
{
    public class Dukkan
    {
        protected int dukkanID { get; set; }
        public string dukkanAdi { get; set; }
        public string adres { get; set; }
        public int alisverisMiktari { get; set; }
        public int HarcamaMiktari { get; set; }
    }
}
