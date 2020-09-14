using System;
using System.Collections.Generic;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs

            Console.WriteLine("Enter a nine digits integer:");
            var input = Console.ReadLine();
            int length = input.Length;
            int number = int.Parse(input);
            var numbers = new List<int>();

            while (length != 9 && numbers[0] >=1)
            {
                Console.WriteLine("error");
                Console.WriteLine("Enter a nine digits integer:");
                input = Console.ReadLine();
                length = input.Length;
                number = int.Parse(input);
            }

            for (int n = 0; n <9; n++)

            {
                int right = number % (int)Math.Pow(10, n + 1 )/ (int)Math.Pow(10, n);
                numbers.Add(right);

            }

            // then check the palindrome only once.
            if (numbers[0] == numbers[8] && numbers[1] == numbers[7] && numbers[2] == numbers[6] && numbers[3] == numbers[5])
            {
                Console.WriteLine("a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }

        }
    }
}
