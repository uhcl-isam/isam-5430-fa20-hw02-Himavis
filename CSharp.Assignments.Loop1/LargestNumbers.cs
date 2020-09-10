using System;
using System.Collections.Generic;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
            // get first number and assign it to variable largest

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int largest = number;
            var numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);

            }

            int largest2 = numbers[numbers.Count - 2];

            Console.WriteLine(largest);
            Console.WriteLine(largest2);
        }
    }
}


