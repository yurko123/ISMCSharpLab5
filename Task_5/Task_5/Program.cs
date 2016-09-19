using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 100, b = (n / 10) % 10;
            n %= 10;
            Console.WriteLine(b * 100 + a * 10 + n);

        }
    }
}
