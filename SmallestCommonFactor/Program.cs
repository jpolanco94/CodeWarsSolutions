using System;

namespace SmallestCommonFactor
{
    class Program
    {
        public static void SmallestCommonFactor()
        {
            int[] pintArray = { 15, 70, 2000, 4590, 10};
            int smallestComFactor = 0;
            int smallestNumber = pintArray[0];
            for(int i = 0; i < pintArray.Length; i++)
            {
                if (smallestNumber > pintArray[i])
                {
                    smallestNumber = pintArray[i];
                }
            }
            for (int i = 2; i <= smallestNumber; i++)
            {
                for (int j = 0; j > pintArray.Length; j++)
                {
                    if (pintArray[j] % i == 0)
                    {
                        smallestComFactor = i;
                    }
                    else smallestComFactor = 0;
                }
                if (smallestComFactor > 0) break;
            }
            if (smallestComFactor == 0)
            {
                smallestComFactor = 1;
            }
            Console.WriteLine(smallestNumber);
            Console.WriteLine(smallestComFactor);
            //return smallestComFactor;
        }
        static void Main(string[] args)
        {
            SmallestCommonFactor();
        }
    }
}
