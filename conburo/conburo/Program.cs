using System;
using System.Collections;

namespace conburo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            ShowCol(list);
            Console.WriteLine();

            list.Add(2.3);
            list.Add(55);
            list.AddRange(new string[] { "Hello", "world" });

            ShowCol(list);
            Console.WriteLine();

            list.RemoveAt(0);

            ShowCol(list);
            Console.WriteLine();

            list.Reverse();
            ShowCol(list);
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShowCol(ArrayList list)
        {
            foreach (object el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
