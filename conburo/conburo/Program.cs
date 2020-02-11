using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace conburo
{
    class Person
    {
        public string Name { get; set; }
    }
    class User
    {
        protected string name;
        protected int? age;

        public string Name { get; set; }
        public int? Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) age = 1;
                else if (value > 120) age = 120;   
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {


            List<int?> nums = new List<int?>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(null);
            nums.Add(3);

            ShowCol(nums);
            Console.WriteLine();
            Console.Read();

        }
        public static void ShowCol(int[] list)
        {
            foreach (int el in list)
            {
                Console.WriteLine(el);
            }
        }
        public static void ShowCol(List<int> list)
        {
            foreach (int el in list)
            {
                Console.WriteLine(el);
            }
        }
        public static void ShowCol(List<int?> list)
        {
            foreach(int? el in list)
            {
                Console.WriteLine(el);
            }
        }

    }

}
