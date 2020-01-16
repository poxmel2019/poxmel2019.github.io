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
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            ShowCol(nums);
            Console.WriteLine();
            
            nums.Add(6);
            ShowCol(nums);
            Console.WriteLine();
            
            nums.AddRange(new int[] {7, 8, 9});
            ShowCol(nums);
            Console.WriteLine();
            
            nums.Insert(0, 666);
            ShowCol(nums);
            Console.WriteLine();
            
            nums.RemoveAt(1);
            ShowCol(nums);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.ReadKey();
            */
            List<Person> people = new List<Person>(3);

            people.Add(new Person() { Name = "Tom" });
            people.Add(new Person() { Name = "Bill" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);

            }

            Console.ReadKey();


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
