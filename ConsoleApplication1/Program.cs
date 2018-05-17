using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veriYapıları_2;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            urun pc1 = new urun();
            pc1.satisFiyat = 100;
            urun pc2 = new urun();
            pc2.satisFiyat = 90;
            urun pc3 = new urun();
            pc3.satisFiyat = 120;
            urun pc4 = new urun();
            pc4.satisFiyat = 130;
            urun pc5 = new urun();
            pc5.satisFiyat = 10;
            urun pc6 = new urun();
            pc6.satisFiyat = 400;
            urunHeapDugum pc1Heap = new urunHeapDugum(pc1);
            urunHeapDugum pc2Heap = new urunHeapDugum(pc2);
            urunHeapDugum pc3Heap = new urunHeapDugum(pc3);
            urunHeapDugum pc4Heap = new urunHeapDugum(pc4);
            urunHeapDugum pc5Heap = new urunHeapDugum(pc5);
            urunHeapDugum pc6Heap = new urunHeapDugum(pc6);
            urunHeap uHeap = new urunHeap(6);
            uHeap.Insert(pc1);
            uHeap.Insert(pc2);
            uHeap.Insert(pc3);
            uHeap.Insert(pc4);
            uHeap.Insert(pc5);
            uHeap.Insert(pc6);
            uHeap.DisplayHeap();
            altKategoriDugum altk = new altKategoriDugum("asda");
            altk.urunEkle(pc1);
            altKategoriIkiliAramaAgac arama = new altKategoriIkiliAramaAgac(altk);
            Console.WriteLine( arama.DugumleriYazdir());
            Console.ReadKey();
        }
    }
}
