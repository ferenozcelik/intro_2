using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    class DatabaseLoggerService : ILoggerService // INHERITANCE
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
