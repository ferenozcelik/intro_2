using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T> // T = type
    {

        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // yeni item ekleyeceğiz fakat alt satırda "new" kullandığımız için
            // önceki değerler yok olacak. tempArray dizisi yok olan bu değerleri yok olma işleminden 
            // önce kendisinde saklayacak ve değerleri bu diziye emanet etmiş olacağız.
            items = new T[items.Length + 1]; // YENİ dizi oluşturur ve dizinin eleman sayısını 
                                             // 1 artırır .

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // emanet olarak tempArray'e verilen değerleri geri alıyoruz
                                         // ve items eski değerlerini tekrar alıyor.
            }

            items[items.Length - 1] = item; 

            // örn: En başta items dizisinde "Fatih" vardı ve uzunluğu 1'di.
            // Fatih'i tempArray'e aldık ve items'ı sıfırlayarak uzunluğunu 1 artırdık, 2 oldu.
            // Sonra for döngüsüyle tempArray'deki her elemanı, items içine aynı pozisyona ekledik.
            // Yani items eski elemanlarını geri almış oldu.
            // items'ın son elemanı boş olduğu için "item"e eşitledik. Yani elemanı eklemiş olduk.
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
