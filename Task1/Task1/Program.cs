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
            if (x == 0 || y == -1.0 / Math.Sqrt(x * x + 10))
            {
                Console.WriteLine("Знаменик = 0 !");
                return ;
            }
            Console.WriteLine((x+(2+y)/(x*x))/(y+1.0/Math.Sqrt(x*x+10)));
            
        }
    }
}
