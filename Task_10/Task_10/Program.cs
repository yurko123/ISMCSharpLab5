using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 50;
            for (int i = 49; i > 0; i--)
            {
                res = i + Math.Sqrt(res);
               
            }
            Console.WriteLine(Math.Sqrt(res));
        }
    }
}
