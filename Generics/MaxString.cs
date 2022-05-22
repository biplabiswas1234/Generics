using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maxstring
    {
        public string FirstString, SecondString, ThirdString;
        public string MaximumString(string FirstString, string SecondString, string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0)
            {
                return FirstString;
            }
            else if (SecondString.CompareTo(ThirdString) > 0 && SecondString.CompareTo(FirstString) > 0)
            {
                return SecondString;
            }
            else if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) > 0)
            {
                return ThirdString;
            }
            return FirstString;
        }
    }
}