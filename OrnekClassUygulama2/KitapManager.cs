using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekClassUygulama2
{
    internal class KitapManager
    {

        public void KitaplariListele(Kitaplar kitaplar)
        {
            Console.WriteLine(kitaplar.KitapAdi + " " + kitaplar.KitapYazari + " " + kitaplar.BasimYili + " " + kitaplar.SayfaSayisi);
        }

        public void SatınAlınan(Kitaplar kitaplar)
        {
            Console.WriteLine(kitaplar.KitapAdi+" adlı kitap satın alındı");
        }

        public void İadeEdilen(Kitaplar kitaplar)
        {
            Console.WriteLine(kitaplar.KitapAdi + " adlı kitap iade edildi");
        }

        public void SayfaKontrol(Kitaplar kitaplar)
        {
            if (kitaplar.SayfaSayisi<500)
            {
                Console.WriteLine(kitaplar.KitapAdi+ " sayfa sayısı 500'ün altındadır");
            }
            else
            {
                Console.WriteLine(kitaplar.KitapAdi+ " sayfa sayısı 500'den fazladır.");
            }
        }

    }
}
