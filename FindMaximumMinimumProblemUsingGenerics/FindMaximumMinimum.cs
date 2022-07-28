using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumMinimumProblemUsingGenerics
{
    /// <summary>
    /// method returns Maximum String value;
    /// </summary>
    public class FindMaximumMinimum
    {
        public static string FindMaximumStringValue(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            else if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            else if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
            {
                return thirdString;
            }
            else
            {
                Console.WriteLine("maximum string not found i.e they are equals");
                return "-1";
            }
        }
    }
}
