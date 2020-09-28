using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Trigonometry
    {
        private double a;
        public Trigonometry(double a)
        {
            this.a = a;
        }
        public double Sin()
        {
            double result = Math.Sin(a);
            return result;
        }
        public double Cos()
        {
            double result = Math.Cos(a);
            return result;
        }
        public double Tan()
        {
            double result = Math.Sin(a) / Math.Cos(a);
            return result;
        }
        public double Ctg()
        {
            double result = Math.Cos(a) / Math.Sin(a);
            return result;
        }
        public double ArcSin()
        {
            double result = Math.Asin(a);
            return result;
        }
        public double ArcCos()
        {
            double result = Math.Acos(a);
            return result;
        }
        public double ArcTan()
        {
            double result = Math.Atan(a);
            return result;
        }
    }
}
