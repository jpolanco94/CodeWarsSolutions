using System;

namespace AlphabetSymmetry
{
    class Program
    {
        //Kata Level 7
        public static int[] AlphabetSymmetryCount(string[] inputArray)
        {
            //First we create a new array with the same length as the string array that holds an integer
            //This will hold how many characters in that string are in their correct alphabetical position.
            int[] alphabetSymmetryCount = new int[inputArray.Length];
            //We then create a char array to compare each element of the string itself with a letter.
            char[] alphabet = {'a','b','c','d','e','f','g','h','i',
                                'j','k','l','m','n','o','p','q','r',
                                's','t','u','v','w','x','y','z'};
            //Now I put every string in the string array to a lowercase position.
            foreach (string s in inputArray)
            {
                s.ToLower();
            }
            //This index was created to iterate through the alphabetSymmetryCount array as well as the inputArray 
            //at the same time. I could've just used a for loop to iterate through both but a foreach loop works well.
            int index = 0;
            //This foreach loop iterates through every element in the inputArray
            foreach (string s in inputArray)
            {
                //This is the counter that will be increased if one of the characters in a string element
                //matches one of the characters in the alphabet array. The counter is initialized outside of the
                // for loop because we want it to initialize to zero before every string is used in the for loop.
                int count = 0;
                //This for loop checks each element of that specific string being used.
                for (int i = 0; i < s.Length; i++)
                {
                    //This boolean expression checks to see if that element of the string is equal to the element of the alphabet
                    //The alphabet is already in order so we can just iterate through it in numerical order.
                    if (s[i] == alphabet[i])
                    {
                        //The count increases by one if the boolean expression is evaluates to true.
                        count++;
                    }
                }
                //The array value we got at whatever specific index is equated to the count value we got in the previous for loop.
                alphabetSymmetryCount[index] = count;
                //The index is increased by one to make sure the next element of alphabetSymmetryCount is modified next.
                //Since the index is initialized outside of the foreach loop, it should remain index + 1 an never go back to zero.
                index++;
            }
            foreach (int x in alphabetSymmetryCount)
            {
                Console.WriteLine(x.ToString() + " ");
            }
            return alphabetSymmetryCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
