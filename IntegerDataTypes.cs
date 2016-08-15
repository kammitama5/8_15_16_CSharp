using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerDataTypes
{
    class IntegerDataTypes
    {
        /// <summary>
        /// Demonstrates Integer Data types
        /// </summary>
    class Program
    {
            /// <summary>
            /// Demonstrates Integer Data types
            /// </summary>
            /// <param name="args">command-line args</param>

            static void Main(string[] args)
            {
                // declare integer variable and constants
                double totalSecondsPlayed = 100.0;
                const double SECONDS_PER_MINUTE = 60.0;
                
                // calculate minutes and seconds
                double minutes = totalSecondsPlayed / SECONDS_PER_MINUTE;
                
                //print results

                Console.Write("Minutes: " + Math.Round(minutes, 2));
                
                

            }
        }
    }
}
