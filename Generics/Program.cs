using System;

namespace Generics
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] intArray = { 19, 25, 46, 35, 97 };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            maxNumber.PrintMax();

            double[] doubleArray = { 65.325, 11.336, 452.12, 56.48, 23.25 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            maxDouble.PrintMax();
            string[] stringArray = { "Apple", "Grapes", "Banana", "Jackfruit" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            maxString.PrintMax();
        }
    }
}
