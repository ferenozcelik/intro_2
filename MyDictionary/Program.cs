using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //test 
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();

            myDict.Add(1, "Fatih");
            myDict.Add(2, "Eren");
            myDict.Add(3, "Arda");
            myDict.Add(4, "Kerem");

            for (int i = 0; i < myDict.Keys.Length; i++)
            {
                Console.WriteLine("Key: " + myDict.Keys[i] + "\tValue: " + myDict.Values[i]);
                Console.WriteLine();
            }
        }
    }
}
