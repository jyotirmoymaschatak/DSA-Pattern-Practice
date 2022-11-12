using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= n; j++)
                    Console.Write("*");
                for (int j = 1; j <= (i-1); j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
