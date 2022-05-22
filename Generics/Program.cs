using System;

namespace Generics
{
        public class Program
        {
            public static void Main(string[] args)
            {
                MaxIntNum maxNumber = new MaxIntNum();
                int MaximumNumber = maxNumber.MaxInteger(10, 20, 30);
                Console.WriteLine("Maximum Integer is " + MaximumNumber);

            }
        }
}
