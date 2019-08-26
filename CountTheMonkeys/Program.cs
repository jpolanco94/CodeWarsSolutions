using System;

namespace CountTheMonkeys
{
    //Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.
    class Program
    {
        public static int[] MonkeyCount(int n)
        {
            int[] monkeyCount = new int[n];
            for (int i = 1; i < monkeyCount.Length + 1; i++)
            {
                monkeyCount[i - 1] = i;
            }
            return monkeyCount;
            throw new System.NotImplementedException();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
