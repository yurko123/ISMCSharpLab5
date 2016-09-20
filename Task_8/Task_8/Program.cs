using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {   double x=2,sum=1;
        for (int i = 1; i <= 10; i++)
        {
            sum += Math.Pow(-1*x, i)*((i+1)*1.0/(i+2));
           
        }
        Console.WriteLine(sum);
        }
    }
}
