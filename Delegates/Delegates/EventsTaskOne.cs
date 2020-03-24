using System;

namespace DelegatesEventOne
{
    class Counter
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    onCount();
                }
            }
        }
    }

    class Handler_I
    {
        public void Message()
        {
            Console.WriteLine("Time to act because it's 71!");
        }
    }

    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Exactly, already 71.");
        }
    }

    class EventsTaskOne
    {
        public static void Run()
        {
            Console.WriteLine("EventsTaskOne");

            Counter counter = new Counter();
            Handler_I handler_I = new Handler_I();
            Handler_II handler_II = new Handler_II();

            counter.onCount += handler_I.Message;
            counter.onCount += handler_II.Message;

            counter.Count();
        }
    }
}
