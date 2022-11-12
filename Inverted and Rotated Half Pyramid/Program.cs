using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverted_and_Rotated_Half_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n - i); j++)
                    Console.Write(" ");
                for(int j=1; j<=i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
