using System;

namespace CSharp.ParameterizedAndFunctional
{
    public static class SumOfFirstNNumbers
    {
        // PARAMETERIZED RECURSION:
        public static void ParameterizedRecursion(int n, int sum)
        {
            if (n<1)
            {
                Console.WriteLine($"Sum: {sum}");
                return;
            }
            ParameterizedRecursion(n-1, sum+n);
        }

        public static int FunctionalRecursrion(int n)
        {
            if (n<1) return 0;
            return n + FunctionalRecursrion(n-1);
        }

        // FUNCTIONAL RECURSION:
        public static void runUsingParameterized()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ParameterizedRecursion(n, 0);
        }

        public static void runUsingFunctional()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum: {FunctionalRecursrion(n)}");
        }
    }
}