using System;

namespace Delegates
{
    class DelegatesTask
    {
        static int MethodOne(bool b, double d, string s)
        {
            Console.WriteLine("MethodOne: {0}, {1:#.0000}, {2}", b, d, s);
            return 0;
        }

        static int MethodTwo(bool b, double d, string s)
        {
            Console.WriteLine("MethodTwo: {0}, {1:#.0000}, {2}", b, d, s);
            return 0;
        }

        delegate int DelegateT(bool b, double d, string s);

        public static void Run()
        {
            Console.WriteLine("DelegatesTask");

            DelegateT dt;

            dt = MethodOne;
            dt += MethodTwo;
            dt += MethodOne;
            dt += MethodOne;
            dt += MethodOne;

            dt(true, 1.2f, "str");
        }
    }
}
