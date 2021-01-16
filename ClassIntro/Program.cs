using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;
            //Console.WriteLine("Hello World!");

            Kurs[] kurslar = new Kurs[] { new Kurs() { KursAdi="C#",Egitmen="Engin Demiroğ",IzlenmeOrani=68},
            new Kurs(){ KursAdi="Java",Egitmen="Kerem Varış",IzlenmeOrani=64 },
            new Kurs(){ KursAdi="Python",Egitmen="Berkay Bilgin",IzlenmeOrani=80 },
            new Kurs(){ KursAdi="C++",Egitmen="Murat Kurtboğan",IzlenmeOrani=100 }};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
