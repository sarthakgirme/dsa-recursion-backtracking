using System;
using System.Reflection.Metadata.Ecma335;

namespace CSharp.ParameterizedAndFunctional
{
    public static class FactorialOfN
    {
        public static void ParameterizedRecursion(int n, int factorial)
        {
            if (n==1)
            {
                Console.WriteLine($"Factorial: {factorial}");
                return;
            }
            ParameterizedRecursion(n-1, factorial*n);
        }

        public static int FunctionalRecursion(int n)
        {
            if (n==1) return 1;
            return n * FunctionalRecursion(n-1);
        }

        public static void runUsingParameterized()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ParameterizedRecursion(n, 1);
        }

        public static void runUsingFunctional()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial: {FunctionalRecursion(n)}");
        }
    }
}