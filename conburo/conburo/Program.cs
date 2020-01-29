using System;
using System.Collections;
using System.Collections.Generic;

namespace conburo
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, string> capitals = new Dictionary<string, string>
            {
                { "France","Paris"},
                { "Germany","Berlin"},
                { "Great Britain","London"},
            };

            foreach(var pair in capitals)
            {
                Console.WriteLine("{0} - {1}",pair.Key, pair.Value);
            }

            Dictionary<string, string> capitals2 = new Dictionary<string, string>
            {
                [ "France"] = "Paris",
                [ "Germany"] = "Berlin",
                [ "Great Britain"] = "London",
            };

            foreach (var pair in capitals2)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.Read();

        }
        public static void ShowCol(List<int> list)
        {
            foreach (object el in list)
            {
                Console.WriteLine(el);
            }
        }

    }

}
