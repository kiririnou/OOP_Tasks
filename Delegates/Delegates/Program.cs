using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesTask.Run();
            Console.WriteLine("------------------------------------------------------");
            DelegatesEventOne.EventsTaskOne.Run();
            Console.WriteLine("------------------------------------------------------");
            DelegatesEventTwo.EventsTaskTwo.Run();

            Console.ReadLine();
        }
    }
}
