using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            short m = short.Parse(Console.ReadLine()), k = short.Parse(Console.ReadLine());
            switch (m) // я по російські 0
            {
                case 6:
                    Console.Write("Шестерка");
                    break;
                case 7:
                    Console.Write("Семерка");
                    break;
                case 8:
                    Console.Write("Восьмерка");
                    break;
                case 9:
                    Console.Write("Девятка");
                    break;
                case 10:
                    Console.Write("Десятка");
                    break;
                case 11:
                    Console.Write("Валет");
                    break;
                case 12:
                    Console.Write("Дама");
                    break;
                case 13:
                    Console.Write("Король");
                    break;
                case 14:
                    Console.Write("Туз");
                    break;
                default:
                    Console.Write(" не правильное число");
                    break;
            }
            switch (k)
            {
                case 1:
                    Console.WriteLine(" пик");
                    break;
                case 2:
                    Console.WriteLine(" треф");
                    break;
                case 3:
                    Console.WriteLine(" бубен");
                    break;
                case 4:
                    Console.WriteLine(" черв");
                    break;
                default:
                    Console.WriteLine(" не правильное число");
                    break;
            }
        }
    }
}
