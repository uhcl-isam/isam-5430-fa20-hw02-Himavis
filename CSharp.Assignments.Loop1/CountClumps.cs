using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunch of integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            //int clump = 0;

            int input;

            while (true)
            {
                Console.WriteLine("Enter an integer:");
                input = Convert.ToInt32(Console.ReadLine());

            }

            //for (var i = 0; i < numbers.Count; i++)
            //{
                 //if (numbers[i] == numbers[i + 1])
                 //{
                     //clump++;
                 //}
            //}
            
            //Console.WriteLine(clump);

        }
    }
}