using System;

namespace CSharp.Subsequences
{
    public static class PrintAllPossibleSubsequences
    {
        public static void parameterizedRecursion(int index, ref List<int> result, ref List<int> arr)
        {
            if (index >= arr.Count)
            {
                foreach (var element in result) Console.Write($"{element} ");
                Console.WriteLine();
                return;
            }

            // Take/Pick the element:
            result.Add(arr[index]);
            parameterizedRecursion(index+1, ref result, ref arr);

            // Remove/Not-Pick the element:
            result.RemoveAt(result.Count-1);
            parameterizedRecursion(index+1, ref result, ref arr);
        }

        public static void run()
        {
            Console.Write("Enter total numbe of Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>(n);
            for (int i=0; i<n; i++) arr.Add(Convert.ToInt32(Console.ReadLine()));
            
            List<int> result = new List<int>();
            Console.WriteLine($"\nSubsequences are:");
            parameterizedRecursion(0, ref result, ref arr);
        }
    }
}