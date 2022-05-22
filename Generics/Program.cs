using System;

namespace Generics
{
        public class Program
        {
           
            public static void Main(string[] args)
            {
            Maxstring maxstring = new Maxstring();
            string MaximumString = maxstring.MaximumString("Apple", "Banana", "Watermelon");
            Console.WriteLine("Maximum String Value is " + MaximumString);

        }
        }
}
