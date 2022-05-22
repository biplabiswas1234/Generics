using System;

namespace Generics
{
        public class Program
        {
           
            public static void Main(string[] args)
            {
            int[] intArray = { 19, 25, 46, 35, 97 };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            Console.WriteLine("The Maximum Integer is " + maxNumber.MaxMethod());

            double[] doubleArray = { 65.325, 11.336, 452.12, 56.48, 23.25 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            Console.WriteLine("The Maximum Float Value is " + maxDouble.MaxMethod());

            string[] stringArray = { "Apple", "Grapes", "Banana", "Jackfruit" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            Console.WriteLine("The Maximum String Value is " + maxString.MaxMethod());
        }
        }
}
