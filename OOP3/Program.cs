using System;
using System.Collections.Generic;

namespace OOP3_Kredi
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            // alttakine de IKrediManager olarak tanımlayabiliriz ama hiçbir şey fark etmeyecek.
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            
            BasvuruManager basvuruManager = new BasvuruManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();
            SmsLoggerService smsLoggerService = new SmsLoggerService();
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);
            //basvuruManager.BasvuruYap(esnafKrediManager, new SmsLoggerService()); | 2. YOL


            Console.WriteLine("\n");

            // kredileri listele
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
