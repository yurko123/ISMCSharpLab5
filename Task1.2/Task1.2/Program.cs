using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if(y<0) y*=-1.0;
            Console.WriteLine(2.8 * Math.Sin(x) + y);
           
        }
    }
}
