using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>() { new SmsLoggerService(), new DatabaseLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //krediler.Add(ihtiyacKrediManager);
            //krediler.Add(konutKrediManager);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
