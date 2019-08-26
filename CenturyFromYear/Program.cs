using System;

namespace CenturyFromYear
{
    //The first century spans from the year 1 up to and including the year 100, The second - from the 
    //year 101 up to and including the year 200, etc.
    //Given a year, return the century it is in.
    class Program
    {
        public static int СenturyFromYear(int year)
        {
            int century = 0;
            if (year % 100 > 0)
            {
                century = (year / 100) + 1;
            }
            else century = (year / 100);
            return century;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
