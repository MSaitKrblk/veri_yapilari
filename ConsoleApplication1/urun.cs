using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları_2
{
    public class urun:IComparable
    {
        public string marka { get; set; }
        public string model { get; set; }
        public decimal satisFiyat { get; set; }
        public decimal maliyet { get; set; }
        public string aciklama { get; set; }
        public int miktar { get; set; }


        public int CompareTo(object obj)
        {
            
            urun u = (urun)obj;
            int sonuc = satisFiyat.CompareTo((int)u.satisFiyat);
            
            return sonuc;           
        }


    }
}
