using System;
using System.Collections.Generic;
using System.Text;

namespace DegerVeReferansTipler
{
    class RefAndOutSampleClass
    {
        public void Topla (int sayi1, ref int sayi2)
        {
            int toplam = sayi1 + sayi2;
            sayi2 = toplam;
            Console.WriteLine("Toplam Sonuç : " + toplam);
        }
        public void Carpim(int sayi1, out int sayi3)
        {
            sayi3 = 12;
            int carpim = sayi1 * sayi3;
            sayi3 = carpim;
            Console.WriteLine("Çarpım Sonuç : " + carpim);
        }
    }
}
