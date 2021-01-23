using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    class TasitKrediManager : IKrediManager // INHERITANCE
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
