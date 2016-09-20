using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double sum=0,l=0,tmp;
            for (int i = 1; i <=N; i++)
            {   tmp=1.0/i;
                if (i % 2 == 0) l-= tmp; 
                else l +=tmp;
                sum += tmp;
            }
            Console.WriteLine(l);
            Console.WriteLine(sum);
        }
    }
}
