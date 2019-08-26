using System;

namespace CountByX
{
    //Create a function with two arguments that will return a list of length (n) with multiples of (x).
    //Assume both the given number and the number of times to count will be positive numbers greater than 0.
    //Return the results as an array
    class Program
    {
        public static class Kata
        {
            public static int[] CountBy(int x, int n)
            {
                int[] z = new int[n];
                for (int i = 1; i < z.Length + 1; i++)
                {
                    z[i - 1] = i * x;
                }


                return z;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}