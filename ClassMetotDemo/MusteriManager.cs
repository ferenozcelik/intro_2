using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Ad: " + musteri.Name
                            + "\nSoyad: " + musteri.Surname
                            + "\nYaş: " + musteri.Age
                            + "\nID: " + musteri.Id
                            + "\nYeni müşteri eklendi.\n");
        }

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Ad: " + musteri.Name
                            + "\nSoyad: " + musteri.Surname
                            + "\nYaş: " + musteri.Age
                            + "\nID: " + musteri.Id
                            + "\nMüşteri silindi.\n");
        }

        public void ListMusteri(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri adı:" + musteri.Name
                    + "\nMüşteri Soyadı: " + musteri.Surname
                    + "\nMüşteri Yaşı: " + musteri.Age
                    + "\nMüşteri ID: " + musteri.Id
                    + "\n");
            }
            Console.WriteLine("Müşteriler listelendi.\n");
        }
    }
}
