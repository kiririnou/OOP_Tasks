using System;

namespace DelegatesEventTwo
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

                    this.onCount -= Handler_I.Message;
                    this.onCount -= Handler_II.Message;
                    this.onCount -= BrandNewHandler.BrandNewMessage;
                }
            }
        }
    }

    class Handler_I
    {
        public static void Message()
        {
            Console.WriteLine("Time to act because it's 71!");
        }
    }

    class Handler_II
    {
        public static void Message()
        {
            Console.WriteLine("Exactly, already 71.");
        }
    }

    class BrandNewHandler
    {
        public static void BrandNewMessage()
        {
            Console.WriteLine("Yep, 71 it is");
        }
    }

    class EventsTaskTwo
    {
        public static void Run()
        {
            Console.WriteLine("EventsTaskTwo");

            Counter counter = new Counter();

            counter.onCount += Handler_I.Message;
            counter.onCount += Handler_II.Message;
            counter.onCount += BrandNewHandler.BrandNewMessage;

            counter.Count();
        }
    }
}
