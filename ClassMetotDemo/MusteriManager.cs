using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, müşteri eklendi : " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri kayıtlardan silindi : " + musteri.Adi);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Bakiye :" + musteri.Bakiye);                
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tebrikler, Müşteriler listelendi ");
        }
    }
}
