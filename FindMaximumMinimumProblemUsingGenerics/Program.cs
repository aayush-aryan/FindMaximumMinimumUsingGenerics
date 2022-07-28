using System;

namespace FindMaximumMinimumProblemUsingGenerics
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Minimum Problem Using Generics :");
            float maximumNumber=FindMaximumMinimum.FindMaximumFloatValue(2.0f, 3.01f, 4.2f);
            Console.WriteLine("Maximum floatValue :", maximumNumber);
        }
    }
}
