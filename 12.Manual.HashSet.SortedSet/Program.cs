using System;
using System.Collections.Generic;
namespace _12.Manual.HashSet.SortedSet {
    class Program {
        static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); // Verifica se esta dentro do conjunto.
            foreach (string p in set) {
                Console.WriteLine(p);
            }
           
        }
    }
}
