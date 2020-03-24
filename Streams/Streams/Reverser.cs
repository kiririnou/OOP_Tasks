using System;
using System.Collections.Generic;
using System.IO;

namespace Streams
{
    class Reverser
    {
        public static void Run()
        {
            Console.WriteLine("Task 1");

            List<string> lines = new List<string>();

            Console.WriteLine("Start reading...");
            using (StreamReader sr = new StreamReader("reverse_in.txt"))
                while (sr.Peek() >= 0)
                    lines.Add(sr.ReadLine());

            lines.Reverse();

            Console.WriteLine("Start writing...");
            using (StreamWriter sw = new StreamWriter("reverse_out.txt"))
                foreach (string line in lines)
                    sw.WriteLine(line);

            Console.WriteLine("Done.");
        }
    }
}
