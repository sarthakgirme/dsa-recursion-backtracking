using System;

namespace CSharp.BasicQuestions
{
    public static class PrintNameNTimes
    {
        public static void recursiveFunction(string name, int i, int n)
        {
            if (i>n) return;
            Console.WriteLine(name);
            recursiveFunction(name, i+1, n);
        }
        
        public static void run()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            recursiveFunction(name, 1, n);
        }
    }
}