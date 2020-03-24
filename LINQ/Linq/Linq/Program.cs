using System;
using System.Linq;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {
                "Alexander", "Constance", "Kobe", "Rene", "Maria",
                "Luna", "Aspen", "Amanda", "Laura", "Alicia"
            };

            Console.WriteLine("Initial:");
            foreach (var name in names)
                Console.Write(name + "  ");

            var results = names.Where((name) => name.StartsWith("A"));

            Console.WriteLine("\nAfter LINQ:");
            foreach (var result in results)
                Console.Write(result + "  ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
