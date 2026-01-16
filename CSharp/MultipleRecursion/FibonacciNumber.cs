using System;

namespace CSharp.MultipleRecursion
{
    public static class FibonacciNumber
    {
        public static int FunctionalRecursion(int n)
        {
            if (n<=1) return n;
            return FunctionalRecursion(n-1) + FunctionalRecursion(n-2);
        }

        public static void run()
        {
            Console.Write("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial: {FunctionalRecursion(n)}");
        }
    }
}