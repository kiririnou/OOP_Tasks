using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousFunctions
{
    class AnonymousFuntionsTask
    {
        delegate double DeletageT(int first, int second, int third);

        double GetAverage(int first, int second, int third)
        {
            double result = 0;
            if (first >= 0) result += first;
            if (second  >= 0) result += second;
            if (third >= 0) result += third;

            result /= 3d;

            Console.WriteLine("GetAverage: {0:0.00}", result);
            return result;
        }

        public void Run()
        {
            int first, second, third;

            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            third = int.Parse(Console.ReadLine());

            DeletageT deletageT;

            deletageT = GetAverage;

            deletageT += delegate(int f, int s, int t) 
            {
                double result = 0;
                if (first >= 0) result += first;
                if (second >= 0) result += second;
                if (third >= 0) result += third;
                result /= 3d;
                result /= 2d;

                Console.WriteLine("Anonymous function: {0:0.00}", result);
                return result;
            };

            deletageT += (int f, int s, int t) => 
            {
                double result = 0;
                if (first >= 0) result += first;
                if (second >= 0) result += second;
                if (third >= 0) result += third;
                result /= 3d;
                result *= 10d;

                Console.WriteLine("Lambda function: {0:0.00}", result);
                return result;
            };

            deletageT(first, second, third);
        }
    }
}