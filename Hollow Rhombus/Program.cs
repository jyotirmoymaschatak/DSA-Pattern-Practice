using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_Rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                if (i == 1 || i == n )
                {
                    for(int j=1;j<=n;j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int j = 0; j < (n-2); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }


                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
