using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    class KonutKrediManager : IKrediManager // INHERITANCE
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
