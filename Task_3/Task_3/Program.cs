using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть трьоцифрове число ");
            int ch = int.Parse(Console.ReadLine());
            int a, b;
            a = ch / 100;
            b = (ch / 10) % 10;
            ch %= 10;
            Console.Write("Кiлькiсть одиниць в числi : ");
            Console.WriteLine(ch);
            Console.Write("Кiлькiсть десяткiв :");
            Console.WriteLine(b);
            Console.Write("Сумма всiх чисел:");
            Console.WriteLine(a + b + ch);
            Console.Write("Добуток:");
            Console.WriteLine(a * b * ch);

        }
    }
}
