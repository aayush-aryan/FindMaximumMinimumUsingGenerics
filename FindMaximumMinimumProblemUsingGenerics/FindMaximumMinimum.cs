using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class FindMaximumMinimum<T> where T : IComparable
    {
        public  T firstValue, secondValue, thirdValue;

        public FindMaximumMinimum()
        {  
        }

        /// <summary>
        /// Parametrised constructor;
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        public FindMaximumMinimum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        /// <summary>
        /// IComparable interface defines a generalized type-specific comparison method that 
        /// a value type or class implements to order or sort its instances.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>

        public static T FindMaximumGenericValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                //Console.WriteLine("maximum string not found i.e they are equals");
                // return default(T);
                throw new Exception("All three values are same");
            }

        }
        //Maximum method
        public  T MaximumValue()
        {
            T max = FindMaximumMinimum<T>.FindMaximumGenericValue(firstValue, secondValue, thirdValue);
            return max;
        }
    }
}
