using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    class qwer
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
    class Program
    {
       
        static void Main(string[] args)
        {
            qwer sd = new qwer();
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(sd.a4(a));
            Console.WriteLine(sd.a6(a));
            Console.WriteLine(sd.a7(a));
            Console.WriteLine(sd.a8(a));
            Console.WriteLine(sd.a9(a));
            Console.WriteLine(sd.a10(a));
            Console.WriteLine(sd.a13(a));
            Console.WriteLine(sd.a15(a));
            Console.WriteLine(sd.a21(a));
            Console.WriteLine(sd.a28(a));
            Console.WriteLine(sd.a64(a));




        }
        

    }
}
