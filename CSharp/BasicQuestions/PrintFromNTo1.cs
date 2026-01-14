using System;

namespace CSharp.BasicQuestions
{
    public static class PrintFromNTo1
    {
        public static void recursiveFunction(int i, int n)
        {
            if (i<1) return;
            Console.Write(i + " ");
            recursiveFunction(i-1, n);
        }
        
        public static void run()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            recursiveFunction(n, n);
        }
    }
}