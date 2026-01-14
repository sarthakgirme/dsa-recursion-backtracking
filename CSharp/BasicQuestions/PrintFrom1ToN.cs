using System;

namespace CSharp.BasicQuestions
{
    public static class PrintFrom1ToN
    {
        public static void recursiveFunction(int i, int n)
        {
            if (i>n) return;
            Console.Write(i + " ");
            recursiveFunction(i+1, n);
        }
        
        public static void run()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            recursiveFunction(1, n);
        }
    }
}