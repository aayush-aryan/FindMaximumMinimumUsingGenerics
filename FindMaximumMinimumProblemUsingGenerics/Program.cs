using System;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Minimum Problem Using Generics :");
            string maxString = FindMaximumMinimum.FindMaximumStringValue("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum StringValue :" + maxString);
        }
    }
}
