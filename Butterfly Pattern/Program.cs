using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            for (int i = 1; i <= n; i++)
            {
                if (i <= (n / 2))
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    for (int j = 1; j <= (n - (2 * i)); j++)
                        Console.Write(" ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                if (i > (n / 2))
                {
                    for (int j = 1; j <= (n + 1 - i); j++)
                        Console.Write("*");
                    for (int j = 1; j <= 2 * (i - (n / 2 + 1)); j++)
                        Console.Write(" ");
                    for (int j = 1; j <= (n + 1 - i); j++)
                        Console.Write("*");
                    Console.WriteLine();
                }


            }
            Console.ReadKey();
        }
    }
}
