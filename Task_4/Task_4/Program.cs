using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = int.Parse(Console.ReadLine());
            int a = ch / 100, b = (ch / 10) % 10;
            ch %= 10;
            ch = a * 100 + ch * 10 + b;
            Console.WriteLine(ch);
        }
    }
}
