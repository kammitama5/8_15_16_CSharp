using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloatingPointNumbers
{
    class FloatingPointNumbers
    {
        /// <summary>
        /// Demonstrates floating point numbers
        /// </summary>
        /// <param name="args"></param>
        class Program
        {
            /// <summary>
            /// Demonstrates floating point numbers
            /// </summary>
            /// <param name="args">command-line args</param>
            static void Main(string[] args)
            {
                // declare variables
                float score = 1356;
                int totalSecondsPlayed = 10000;

                // calculate and display result
                float pointPerSecond = score / totalSecondsPlayed;

                // print output
                Console.WriteLine("Points per second " + Math.Round(pointPerSecond, 3));
                Console.WriteLine();


            }
        }
    }
}
