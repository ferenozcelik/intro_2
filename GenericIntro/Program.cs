using System;
using System.Collections.Generic;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>(); // string yerine int de yazılabilir. 
                                         // Generic kullandığımız için kolayca değiştirebiliyoruz.
            isimler.Add("Fatih");
            Console.WriteLine(isimler.Length);

            isimler.Add("Eren");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
