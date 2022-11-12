using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_Triangle_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int flag = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    flag = 0;
                else
                    flag = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(flag + " ");
                    if (flag == 1) flag = 0;
                    else flag = 1;
                }
                for (int j = 1; j <= (n - i); j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
