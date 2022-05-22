using System;

namespace Generics
{
        public class Program
        {
           
            public static void Main(string[] args)
            {
            MaxFloatNum maxFloatNum = new MaxFloatNum();
            double MaximumNumber = maxFloatNum.MaximumFloat(1.2, 2.2, 0.2);
            Console.WriteLine("Maximum Float Number is " + MaximumNumber);

            }
        }
}
