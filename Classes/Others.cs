using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Others
    {
        private double a, b;
        public bool IsTrue = false;

        public Others(double a)
        {
            this.a = a;
        }
        public Others(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Sqrt()
        {
            double result = Math.Sqrt(a);
            return result;
        }
        public double Power()
        {
            double result = Math.Pow(a, b);
            return result;
        }
        public double Power_of_10()
        {
            double result = a * Math.Pow(10, b);
            return result;
        }
    }
}
