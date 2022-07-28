using System;

namespace FindMaximumMinimumProblemUsingGenerics
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Minimum Problem Using Generics :");
            int maximumNumber=FindMaximumMinimum.FindMaximumInteger(70, 80, 90);
            Console.WriteLine("Maximum Integers is :{0}", maximumNumber);
        }
    }
}
