using System;

namespace CSharp.BasicQuestions
{
    public static class PrintFromNTo1_Backtracking
    {
        public static void recursiveFunction(int i, int n)
        {
            if (i>n) return;
            recursiveFunction(i+1, n);
            Console.Write(i + " ");
        }
        
        public static void run()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            recursiveFunction(1, n);
        }
    }
}