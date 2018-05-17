using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veriYapıları_2;

namespace ConsoleApplication1
{
    public class altKategoriDugum
    {
        urunHeap urunler = new urunHeap(100);
        public string kategoriIsim { get; set; }
        public altKategoriDugum sag { get; set; }
        public altKategoriDugum sol { get; set; }
        public altKategoriDugum()
        {

        }

        public altKategoriDugum(string isim)
        {
            kategoriIsim = isim;
            sol = null;
            sag = null;
        }
        public void urunEkle(urun u)
        {
            urunler.Insert(u);
        }
    }
}
