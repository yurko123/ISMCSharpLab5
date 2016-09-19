using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    class Class1
    {
        public double a4(double a)
        {
            a *= a;
            a *= a;
            return a;
        }

        public double a6(double a)
        {
            double b = a * a * a;
            b *= b;

            return b;
        }
        public double a7(double a)
        {
            double b = a * a;
            b *= b;
            b *= b;
            b /= a;
            return b;
        }
        public double a8(double a)
        {
            a *= a;
            a *= a;
            a *= a;
            return a;
        }
        public double a9(double a)
        {
            double b = a * a * a;
            a = b * b * b;
            return a;
        }
        public double a10(double a)
        {
            double b = a * a;
            a = b * b;
            b = b * a * a;
            return b;
        }
        public double a13(double a)
        {
            double b = a * a * a;
            b = b * b * b;
            b *= a;
            return b;
        }
        public double a15(double a)
        {
            double b = a * a;
            b = b * b * a;
            b = b * b * b;
            return b;
        }
        public double a21(double a)
        {
            double b = a * a;
            b = b * b * b * a;
            b = b * b * b;
            return b;
        }
        public double a28(double a)
        {
            double b = a * a;
            b = b * b * b * a;
            b = b * b;
            b = b * b;
            return b;
        }
        public double a64(double a)
        {
            a = a * a;
            a = a * a;
            a = a * a;
            a = a * a;
            a = a * a;
            a = a * a;
            return a;
        }
    }
}
