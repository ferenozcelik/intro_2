using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    class IhtiyacKrediManager : IKrediManager // INHERITANCE
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
