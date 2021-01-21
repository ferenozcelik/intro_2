using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2>
    {
        // arrays
        T1[] keys;
        T2[] values;
        
        public MyDictionary()
        {
            //constructor
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            T1[] tempKeys = keys; // keys'in önceki değerlerini sakladık
            keys = new T1[keys.Length + 1]; // yeni keys oluşturduk

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key; // son index'i parametre olarak verdiğimiz değere eşitledik.

            //

            T2[] tempValues = values;
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;
        }

        public T1[] Keys
        {
            get { return keys; }
        }
        public T2[] Values
        {
            get { return values; }
        }

    }
}
