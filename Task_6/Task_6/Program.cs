using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 400 == 0 || year % 100 > 0)
                {
                    Console.WriteLine("Високосний");
                    return;
                }
            }
            
               Console.WriteLine("Не високосний");

        }
    }
}
