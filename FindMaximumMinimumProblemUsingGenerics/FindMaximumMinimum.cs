using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class FindMaximumMinimum
    {
        public static float FindMaximumFloatValue(float firstNumber, float secondNumber, float thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            else
            {
                Console.WriteLine("maximum number not found i.e they are equals");
                return -1;
            }
        }
    }
}
