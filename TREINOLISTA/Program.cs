using System;
using System.Collections.Generic;

namespace TREINOLISTA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("João");
            list.Add("Carlos");
            list.Add("Amanda");
            list.Add("Alex");
            list.Insert(2, "Pedro");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de nomes: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x =>x[0] == 'A');
            Console.WriteLine("Last 'A': "+ s2);

            Console.WriteLine();
            Console.WriteLine("Nome com 5 caracteres:");
            List <string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
