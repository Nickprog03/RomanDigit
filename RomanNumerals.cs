using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        private static readonly Dictionary<char, int> romanDigits = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int RomanToInt(string roman)
        {
            int total = 0;
            char previousChar = roman[0];
            foreach (char currentChar in roman)
            {
                total += romanDigits[currentChar];
                if (romanDigits[previousChar] < romanDigits[currentChar])
                {
                    total -= romanDigits[previousChar] * 2;
                }
                previousChar = currentChar;
            }
            return total;
        }

        static void Main(string[] args)
        {
            string RomanString = "MMCMLXXXIV";
            int IntegerNumber = RomanToInt(RomanString);
            Console.WriteLine(IntegerNumber);


            //Console.WriteLine(RomanToInteger("MMCMLXXXIV")); //example
        }
    }
}
