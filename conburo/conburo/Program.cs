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

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("one","1");
            dict.Add("two",null);
            string wor = null;
            foreach(KeyValuePair<string,string> el in dict)
            //foreach (var el in dict)

                {
                    if (el.Value == null) { wor = "2"; }
                Console.WriteLine(el.Key + " - " + el.Value);

            }
            Console.WriteLine(wor);

            string word = "";
            string empty = null;
            //string word2 = empty.ToString();
            //Console.WriteLine(word2.GetType());
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
