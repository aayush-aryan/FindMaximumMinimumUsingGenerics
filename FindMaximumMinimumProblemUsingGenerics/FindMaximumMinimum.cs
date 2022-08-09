using System;
using System.Collections.Generic;
using System.Text;
namespace FindMaximumMinimumProblemUsingGenerics
{
    public class FindMaximumMinimum<T> where T : IComparable
    {
        /// <summary>
        /// IComparable interface defines a generalized type-specific comparison method that 
        /// a value type or class implements to order or sort its instances.
        /// </summary>
        public T[] genericArray;
        /// <summary>
        /// no argument constructor
        /// </summary>
        public FindMaximumMinimum()
        {  
        }
        /// <summary>
        /// Parametreized Constructor 
        /// </summary>
        /// <param name="array"></param>
        public FindMaximumMinimum(T [] array)
        {
            this.genericArray = array;
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="values"></param>
       /// <returns></returns>
        public T[] Sort(T[] values)
        {
           // Sorts the elements in an entire System.Array using the System.IComparable`1 generic
          // interface implementation of each element of the System.Array. Valid for 1D array;
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// By using the params keyword, you can specify a method parameter that takes a variable number of arguments.
        /// The parameter type must be a single-dimensional array.
       /// No additional parameters are permitted after the params keyword in a method declaration,
       /// and only one params keyword is permitted in a method declaration.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            //calling sort method as defined above
            T[] sortedArray = Sort(this.genericArray);
            // return last element of sorted array as maximum;
            return sortedArray[sortedArray.Length - 1];
        }
        /// <summary>
        /// method to print MaximumValue
        /// </summary>
        public void PrintMax()
        {
            var maxValue = MaxValue(this.genericArray);
            Console.WriteLine("The maximum value is: " + maxValue);
        }
    }
}
