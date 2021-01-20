using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri silinecek = new Musteri
            {
                Name = "silinecek",
                Surname = "silinecek",
                Age = 00,
                Gender = '.',
                Id = 000000000
            };

            Musteri musteri1 = new Musteri
            {
                Name = "Eren",
                Surname = "Özçelik",
                Age = 19,
                Gender = 'E',
                Id = 190101006
            };

            Musteri musteri2 = new Musteri
            {
                Name = "Fatih",
                Surname = "Erdem",
                Age = 23,
                Gender = 'E',
                Id = 190121034
            };

            Musteri musteri3 = new Musteri
            {
                Name = "Anıl",
                Surname = "Kaya",
                Age = 22,
                Gender = 'E',
                Id = 190121036
            };

            Musteri musteri4 = new Musteri
            {
                Name = "Arzu",
                Surname = "Uç",
                Age = 25,
                Gender = 'F',
                Id = 190124005
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Remove(silinecek);
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);

            Musteri[] musteriListe = new Musteri[]
            {
                musteri1, musteri2, musteri3, musteri4
            };

            musteriManager.ListMusteri(musteriListe);

        }
    }
}
