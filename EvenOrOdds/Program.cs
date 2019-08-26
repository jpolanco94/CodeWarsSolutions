using System;

namespace EvenOrOdds
{
    //Create a function(or write a script in Shell) that takes an integer as an argument and returns 
    //"Even" for even numbers or "Odd" for odd numbers.
    public class Program
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else return "Odd";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
