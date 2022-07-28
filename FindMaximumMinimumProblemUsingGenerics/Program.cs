using System;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Minimum Problem Using Generics :");
            int maxInteger = FindMaximumMinimum.FindMaximumGenericValue<int>(20, 30, 40);
            Console.WriteLine("Maximum IntegerValue :" + maxInteger);
            float maxFloat = FindMaximumMinimum.FindMaximumGenericValue<float>(0.2f, 0.3f, 0.4f);
            Console.WriteLine("Maximum FloatValue :" + maxFloat);
            string maxString = FindMaximumMinimum.FindMaximumGenericValue<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum StringValue :" + maxString);
        }
    }
}
