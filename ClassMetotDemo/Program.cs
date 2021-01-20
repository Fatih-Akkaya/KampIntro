using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[] { new Musteri() { Adi = "Fatih", Soyadi = "Akkaya", Bakiye = 100.5 },
            new Musteri(){Adi="Furkan", Soyadi="Yılmaz", Bakiye=500.95 }, 
            new Musteri(){Adi="Engin", Soyadi="Demiroğ", Bakiye=1250 } };
            
            Console.WriteLine("---------------Müşteri Ekleme-------------------");
            MusteriManager musteriManager = new MusteriManager();
            for (int i=0;i<musteriler.Length;i++)
            {
                musteriManager.Ekle(musteriler[i]);
            }
            Console.WriteLine("---------------Müşteri Listeleme-------------------");
            musteriManager.Listele(musteriler);
            Console.WriteLine("---------------Müşteri Silme-------------------");
            musteriManager.Sil(musteriler[0]);
            musteriManager.Sil(musteriler[1]);
            
        }
    }
}
