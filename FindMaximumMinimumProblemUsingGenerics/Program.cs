using System;

namespace FindMaximumMinimumProblemUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Minimum Problem Using Generics :");
            // int maxInteger = FindMaximumMinimum.FindMaximumGenericValue<int>(20, 30, 40);
            // Console.WriteLine("Maximum IntegerValue :" + maxInteger);
            // float maxFloat = FindMaximumMinimum.FindMaximumGenericValue<float>(0.2f, 0.3f, 0.4f);
            //Console.WriteLine("Maximum FloatValue :" + maxFloat);
            //  string maxString = FindMaximumMinimum.FindMaximumGenericValue<string>("Apple", "Peach", "Banana");
            // Console.WriteLine("Maximum StringValue :" + maxString);

            // int array
            int[] intArray = { 33, 22, 11, 10 };
            // Float array
            float[] floatArray = { 33.3f, 22.2f, 11.1f, 10.0f };
            // String array
            string[] stringArray = { "Peach", "Apple", "Bannana", "Grapes" };
            //Invoke the method and print maximum value
            new FindMaximumMinimum<int>(intArray).PrintMax();
            new FindMaximumMinimum<float>(floatArray).PrintMax();
            new FindMaximumMinimum<string>(stringArray).PrintMax();

        }
    }
}
