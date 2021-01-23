using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Fatih");

            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1, "Yusuf Emir");
            ogrenciler.Add(2, "Zeynep Sıla");
            ogrenciler.Add(3, "Fethi");
            Console.WriteLine(ogrenciler.Count);

            for (int i=0;i<ogrenciler.Count;i++)
            {
                Console.WriteLine(ogrenciler.Key(i) + " : " + ogrenciler.Value(i));
            }
            ogrenciler.Add(3, "Fatih");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine(ogrenciler.Key(i) + " : " + ogrenciler.Value(i));
            }
        }
    }
}
