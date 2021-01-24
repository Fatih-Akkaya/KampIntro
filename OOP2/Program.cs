using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";
            //musteri1.VergiNo = "?";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri2 = new GercekMusteri();
            musteri2.MusteriNo = "12312";
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";
            musteri2.TcNo = "12345678910";

            TuzelMusteri musteri3 = new TuzelMusteri();
            musteri3.Id = 3;
            musteri3.MusteriNo = "12313";
            musteri3.SirketAdi = "kodlama.io";
            musteri3.VergiNo = "1234567890";

            Musteri musteri4 = new GercekMusteri(); //new "reference number"
            Musteri musteri5 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
        }
    }
}
