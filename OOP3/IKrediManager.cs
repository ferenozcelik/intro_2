using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Kredi
{
    interface IKrediManager // interface olduğunu anlamak için başına "I" harfi koyduk.
    {
        //interface'i bir şablon olarak da görebiliriz. içeriğindeki şablona diğer class'lar uymak zorundadır.
        void Hesapla(); 
        // Diğer tüm kredi manager'larda Hesapla() metodunun içeriği farklı olacağından dolayı,
        // KrediManager'ı class olarak değil, INTERFACE olarak tanımlıyoruz. INTERFACE olarak 
        // tanımladığımızdan dolayı metodun içeriğini burada yazmak zorunda değiliz.
        // Onun yerine Hesapla() metodunun içeriğini tüm kredi managerlar'da farklı farklı yazacağız.

    }
}
