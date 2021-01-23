using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            
            myDictionary.Add(100, "Samet DOGAN");
            myDictionary.Add(101, "Engin DEMİROG");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
