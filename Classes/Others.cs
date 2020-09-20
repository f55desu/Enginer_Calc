using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Others
    {
        private double a, b;

        public Others(double a)
        {
            this.a = a;
        }
        public double Sqrt()
        {
            double result = Math.Sqrt(a);
            return result;
        }
    }
}
