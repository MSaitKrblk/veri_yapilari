using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veriYapıları_2;

namespace ConsoleApplication1
{
    public class altKategoriIkiliAramaAgac
    {
        private altKategoriDugum kok;
        private string dugumler;
        public altKategoriIkiliAramaAgac()
        {
        }
        public altKategoriIkiliAramaAgac(altKategoriDugum kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(altKategoriDugum dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(altKategoriDugum dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(altKategoriDugum dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(altKategoriDugum dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(altKategoriDugum dugum)
        {
            dugumler += dugum.kategoriIsim + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(altKategoriDugum dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(string deger , String kategoriAd)
        {
            //Yeni eklenecek düğümün parent'ı
            // compare metodu gelecek !!!!!!!!!!!!!
            altKategoriDugum tempParent = new altKategoriDugum();
            //Kökten başla ve ilerle
            altKategoriDugum tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (string.Compare(deger, tempSearch.kategoriIsim) == 0)
                    return;
                else if (string.Compare(deger, tempSearch.kategoriIsim) == -1)
                    tempSearch = tempSearch.sol;
                else if (string.Compare(deger, tempSearch.kategoriIsim) == 1)
                    tempSearch = tempSearch.sag;
            }
            altKategoriDugum eklenecek = new altKategoriDugum(deger);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(deger, tempSearch.kategoriIsim) == -1)
                tempParent.sol = eklenecek;
            else if (string.Compare(deger, tempSearch.kategoriIsim) == 1)
                tempParent.sag = eklenecek;
        }
        public altKategoriDugum Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private altKategoriDugum AraInt(altKategoriDugum dugum,
                                            int anahtar)
        {
            //if (dugum == null)
            //    return null;
            //else if ((int)dugum.veri == anahtar)
            //    return dugum;
            //else if ((int)dugum.veri > anahtar)
            //    return (AraInt(dugum.sol, anahtar));
            //else
            //    return (AraInt(dugum.sag, anahtar));
            return null;
        }

        public altKategoriDugum MinDeger()
        {
            altKategoriDugum tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }

        public altKategoriDugum MaksDeger()
        {
            altKategoriDugum tempSag = kok;
            while (tempSag.sag != null)
                tempSag = tempSag.sag;
            return tempSag;
        }

        private altKategoriDugum Successor(altKategoriDugum silDugum)
        {
            altKategoriDugum successorParent = silDugum;
            altKategoriDugum successor = silDugum;
            altKategoriDugum current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(int deger)
        {
            return false;
            //altKategoriDugum current = kok;
            //altKategoriDugum parent = kok;
            //bool issol = true;
            ////DÜĞÜMÜ BUL
            //while ((int)current.veri != deger)
            //{
            //    parent = current;
            //    if (deger < (int)current.veri)
            //    {
            //        issol = true;
            //        current = current.sol;
            //    }
            //    else
            //    {
            //        issol = false;
            //        current = current.sag;
            //    }
            //    if (current == null)
            //        return false;
            //}
            ////DURUM 1: YAPRAK DÜĞÜM
            //if (current.sol == null && current.sag == null)
            //{
            //    if (current == kok)
            //        kok = null;
            //    else if (issol)
            //        parent.sol = null;
            //    else
            //        parent.sag = null;
            //}
            ////DURUM 2: TEK ÇOCUKLU DÜĞÜM
            //else if (current.sag == null)
            //{
            //    if (current == kok)
            //        kok = current.sol;
            //    else if (issol)
            //        parent.sol = current.sol;
            //    else
            //        parent.sag = current.sol;
            //}
            //else if (current.sol == null)
            //{
            //    if (current == kok)
            //        kok = current.sag;
            //    else if (issol)
            //        parent.sol = current.sag;
            //    else
            //        parent.sag = current.sag;
            //}
            ////DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            //else
            //{
            //    altKategoriDugum successor = Successor(current);
            //    if (current == kok)
            //        kok = successor;
            //    else if (issol)
            //        parent.sol = successor;
            //    else
            //        parent.sag = successor;
            //    successor.sol = current.sol;
            //}
            //return true;
        }

    }
}
