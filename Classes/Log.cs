using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Log
    {
        private double a, b, c;

        public Log(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Log(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Log(double a)
        {
            this.a = a;
        }

        public double log()
        {
            double result = Math.Log(a, b);
            return result;
        }
        public double lg()
        {
            double result = Math.Log10(a);
            return result;
        }
        public double ln()
        {
            double result = Math.Log(a);
            return result;
        }
        public double Reverse_Log()
        {
            double result = Math.Pow(b, c);
            return result;
        }
    }
}
