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

            int pev = 0;
            bool isCheck = true;
            int count = 0;
            int i = 0; 

            while (true)
            {
                Console.WriteLine("Enter an integer:");
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                int n = int.Parse(input);
                if (i == 0)
                {
                    pev = n;
                    i++;
                }
                else if (pev = n && isCheck == true)
                {
                    count++;
                    isCheck = false;
                }
            }

           

        }
    }
}