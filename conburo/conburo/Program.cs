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
            string s;
            s += "string";
            Console.WriteLine(s);
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
