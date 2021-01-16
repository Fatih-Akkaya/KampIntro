using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double vadeFarki = 1.45;
            bool sistemeGirisYapmisMi = sistemeGirisYapmisMiBiBak();
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış butonu");
            } else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
        static bool sistemeGirisYapmisMiBiBak()
        {
            return true;
        }
    }
}
