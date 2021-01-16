using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun[] urunler = new Urun[] { new Urun() { Adi = "Elma", Fiyati = 15, Aciklama = "Amasya elması" },
            new Urun(){Adi="Karpuz", Fiyati=80, Aciklama="Diyarbakır karpuzu" } };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------------Metotlar-------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urunler[0]);
            sepetManager.Ekle(urunler[1]);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80);
        }
    }
}

//Don't repeat yourself - DRY
//Clean code
