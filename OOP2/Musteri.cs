using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        // Tüm müşteriler için ortak özellikler.
        public int Id { get; set; }
        public string MusteriNo { get; set; } // long da yazabilirdik fakat sayıyla işlem 
        //yapmayacaksan long olarak tanımlamaya gerek yok. Excel'de sıkıntı çıkarabilir.

    }
}
