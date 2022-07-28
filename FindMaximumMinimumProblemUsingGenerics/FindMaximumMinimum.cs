using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class FindMaximumMinimum
    {
        /// <summary>
        /// IComparable interface defines a generalized type-specific comparison method that 
        /// a value type or class implements to order or sort its instances.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <param name="thirdString"></param>
        /// <returns></returns>
        public static T FindMaximumGenericValue<T>(T firstString, T secondString, T thirdString) where T : IComparable
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
                return default(T);
            }
        }
    }
}
