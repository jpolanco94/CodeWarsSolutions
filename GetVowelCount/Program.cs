using System;

namespace GetVowelCount
{
    public class Program
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            int length = str.Length;
            string lowerStr = str.ToLower();
            for (int i = 0; i < length; i++)
            {
                char x = Convert.ToChar(lowerStr[i]);
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
