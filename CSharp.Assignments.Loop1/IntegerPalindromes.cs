using System;
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
            int input = int.Parse(Console.ReadLine());
            int right1 = input % 10;
            int right2 = input % 100 / 10;
            int right3 = input % 1000 / 100;
            int right4 = input % 10000 / 1000;
            int right5 = input % 100000 / 10000;
            int right6 = input % 1000000 / 100000;
            int right7 = input % 10000000 / 1000000;
            int right8 = input % 100000000 / 10000000;
            int right9 = input % 1000000000 / 100000000;

            while (input / 1000000000 <= 0)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Enter a nine digits integer:");
            }

            // then check the palindrome only once.

            {
                if (right1 == right9 && right2 == right8 && right3 == right7 && right4 == right6)
                {
                    Console.WriteLine("a palindrome");
                }
                else
                {
                    Console.WriteLine(" not a palindrome");
                }
            }
          
        }
    }
}
