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
            /*
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Russia");
            countries.Add(2, "Great Britain");
            countries.Add(3, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            //foreach (KeyValuePair<int,string> keyValue in countries)
            //{
            //    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            //}

            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill"});
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "John" });
            people.Add('d', new Person() { Name = "Dilan" });
            people['e'] = new Person() { Name = "Eric" };

            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            foreach(char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            foreach(Person n in people.Values)
            {
                Console.WriteLine(n.Name);
            }
            */
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
