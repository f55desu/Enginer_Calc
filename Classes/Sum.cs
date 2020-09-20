using System;

namespace Classes
{
    public class Sum
    {
        private double a;
        private double b;

        public Sum(double a_fs, double b_fs)
        {
            this.a = a_fs;
            this.b = b_fs;
        }
        public double Summary()
        {
            double sum = a + b;
            return sum;
        }
        public double Difference()
        {
            double diff = a - b;
            return diff;
        }
        public double Division()
        {
            double div = a / b;
            return div;
        }
        public double Multiply()
        {
            double multi = a * b;
            return multi;
        }
    }
}
