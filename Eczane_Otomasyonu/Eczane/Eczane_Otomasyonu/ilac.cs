using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Otomasyonu
{
   public class ilac
    {
        public int Barkod { get; set; }
        public string Ad { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public int Kutu { get; set; }
        public override string ToString()
        {
            return Ad + " " + Kutu;
        }


    }
}
