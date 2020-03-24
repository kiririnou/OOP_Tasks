using System;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Reverser.Run();

            Console.WriteLine();

            Seeker.Run();

            Console.ReadLine();
        }
    }
}
