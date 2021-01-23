using System;

namespace OOP3_Kredi
{
    class FileLoggerService : ILoggerService // INHERITANCE
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
