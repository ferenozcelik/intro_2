using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // parametre olarak IKrediManager verdik.
        // IKrediManager INTERFACE olduğu için tüm kredi türlerini çalıştırabilecek güçtedir.
        // KrediManager instance'ları oluştururken başına IKrediManager yazdığımızda da fark olmadan çalışabildiğinin başka bir kanıtıdır.
        // Eğer 2 tane LoggerService parametresi vereceksek:
        // List<ILoggerService> loggerServices => bu parametreyi girerek liste verebiliriz.
        {
            krediManager.Hesapla(); // Gönderdiğin kredi türünün Hesapla() metodu çalışır.
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
