using System;

namespace visual_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountTestsRomanNumbers = 3;
            ushort[] testRomanNumbers = { 1, 2000, 3999 };

            for (int i = 0; i < amountTestsRomanNumbers; i++)
            {
                RomanNumber romanNumber = new RomanNumber(testRomanNumbers[i]);
                Console.WriteLine($"{testRomanNumbers[i]}: " + romanNumber.ToString());
            }

            RomanNumber testOperationRomanNum1 = new RomanNumber(10);
            RomanNumber testOperationRomanNum2 = new RomanNumber(5);

            Console.Write("\n10 + 5 = ");
            Console.WriteLine(testOperationRomanNum1 + testOperationRomanNum2);

            Console.Write("\n10 - 5 = ");
            Console.WriteLine(testOperationRomanNum1 - testOperationRomanNum2);

            Console.Write("\n10 * 5 = ");
            Console.WriteLine(testOperationRomanNum1 * testOperationRomanNum2);

            Console.Write("\n10 / 5 = ");
            Console.WriteLine(testOperationRomanNum1 / testOperationRomanNum2);

            RomanNumber[] testSortRomanNums = { new RomanNumber(5), new RomanNumber(1), new RomanNumber(2), new RomanNumber(4) };

            Console.WriteLine("\nArray before sort:");
            foreach (var num in testSortRomanNums)
            {
                Console.Write(num.ToString() + " ");
            }

            Array.Sort(testSortRomanNums);

            Console.WriteLine("\nArray after sort:");
            foreach (var num in testSortRomanNums)
            {
                Console.Write(num.ToString() + " ");
            }




        }
    }
}
