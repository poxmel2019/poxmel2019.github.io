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
        static void Main(string[] args)
        {
            Dictionary<string,int?> dict = new Dictionary<string,int?>();
            dict.Add("provider",123456);
            dict.Add("service",null);
            
            foreach(KeyValuePair<string,int?> kv in dict)
            {
                Console.WriteLine(kv.Key + " - " + kv.Value);
            }

            List<User> users = new List<User>()
            {
                new User { Name = "Tom", Age = 23},
                new User { Name = "Sam", Age = 43},
                new User { Name = "Bill", Age = 35},
                new User { Name = "Shiva", Age = null}
            };

            bool res1 = users.Any(u => u.Age < 20 || u.Age == null);
            if (res1)

                Console.WriteLine("There are users with age less than 20");

            else
                Console.WriteLine("All users have age more than 20");

            bool res2 = users.Any(u => u.Name.StartsWith("T"));
            if (res2)
            {
                Console.WriteLine("There are users whose names starts with \"T\"");
            }
            else
                Console.WriteLine("There are no users whose names starts with \"T\"");
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            string ass = null;
            Console.WriteLine(ass);
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
