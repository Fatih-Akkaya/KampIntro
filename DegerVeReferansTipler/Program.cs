using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            //sayi1 = sayi2;
            //sayi2 = 65;
            //Console.WriteLine(sayi1);

            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            //Console.WriteLine(sayilar1[0]);

            RefAndOutSampleClass refAndOutSample = new RefAndOutSampleClass();
            Console.WriteLine("Topla Methodu çalışmadan önce sayi2 : " + sayi2);
            refAndOutSample.Topla(sayi1, ref sayi2);
            Console.WriteLine("Topla Methodu çalıştıktan sonra sayi2 : " + sayi2);
            int sayi3;

            //Console.WriteLine("Çarpım Methodu çalışmadan önce sayi3 : " + sayi3);
            refAndOutSample.Carpim(sayi2, out sayi3);
            Console.WriteLine("Çarpım Methodu çalıştıktan sonra sayi3 : " + sayi3);
            sayi3 = 8;
            refAndOutSample.Carpim(sayi2, out sayi3);
            Console.WriteLine("Çarpım Methodu 2. kez çalıştıktan sonra sayi3 : " + sayi3);
        }
    }
}
