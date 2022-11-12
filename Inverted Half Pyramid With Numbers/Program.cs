using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverted_Half_Pyramid_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n + 1 - i); j++)
                    Console.Write(j);
                for (int j = 1; j <= (i-1); j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
