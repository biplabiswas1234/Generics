﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class MaxFloatNum
    {

        public double Num1, Num2, Num3;
        public double MaximumFloat(double Num1, double Num2, double Num3)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1;
            }
            else if (Num2.CompareTo(Num3) > 0 && Num2.CompareTo(Num1) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            return Num1;
        }
    }

}

