// See https://aka.ms/new-console-template for more information


using OrnekClassUygulama2;

Kitaplar kitap1= new Kitaplar();
kitap1.KitapAdi = "Harry Potter ve ZÜmrüdüanka Yoldaşlığı";
kitap1.KitapYazari = "J.K.Rowling";
kitap1.BasimYili = 2003;
kitap1.SayfaSayisi = 975;

Kitaplar kitap2 = new Kitaplar();
kitap2.KitapAdi = "Martin Eden";
kitap2.KitapYazari = "Jack London";
kitap2.BasimYili = 2014;
kitap2.SayfaSayisi = 517;

Kitaplar kitap3 = new Kitaplar();
kitap3.KitapAdi = "Koleksiyoncu";
kitap3.KitapYazari = "John Fowles";
kitap3.BasimYili = 1992;
kitap3.SayfaSayisi = 303;

Kitaplar kitap4 = new Kitaplar();
kitap4.KitapAdi = "Ecce Homo";
kitap4.KitapYazari = "Friedrich Nietzsche";
kitap4.BasimYili =2017;
kitap4.SayfaSayisi = 120;

Kitaplar[] kitap = new Kitaplar[]
{
    kitap1,kitap2,kitap3,kitap4
};

//foreach (var kitaplik in kitap)
//{
//    Console.WriteLine(kitaplik.KitapAdi+" "+kitaplik.KitapYazari+" "+kitaplik.BasimYili+" "+kitaplik.SayfaSayisi);
//}

KitapManager manager = new KitapManager();
Console.WriteLine("~~~~KİTAPLAR LİSTESİ~~~~");
manager.KitaplariListele(kitap1);
manager.KitaplariListele(kitap2);
manager.KitaplariListele(kitap3);
manager.KitaplariListele(kitap4);
Console.WriteLine("--------------------");
KitapManager satin = new KitapManager();
satin.SatınAlınan(kitap1);

Console.WriteLine("--------------------");
KitapManager iade = new KitapManager();
iade.İadeEdilen(kitap3);

Console.WriteLine("--------------------");
KitapManager kontrol = new KitapManager();
kontrol.SayfaKontrol(kitap1);
kontrol.SayfaKontrol(kitap2);
kontrol.SayfaKontrol(kitap3);
kontrol.SayfaKontrol(kitap4);

