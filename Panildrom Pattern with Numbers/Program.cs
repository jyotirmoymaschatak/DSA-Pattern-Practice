using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panildrom_Pattern_with_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n - i); j++)
                    Console.Write(" ");

                int flag = i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(flag);
                    flag--;
                }
                flag = 2;
                for (int j = 1; j <= (i - 1); j++)
                {
                    Console.Write(flag);
                    flag++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
