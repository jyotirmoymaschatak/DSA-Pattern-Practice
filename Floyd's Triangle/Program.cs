using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyd_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(sum + " ");
                    sum++;
                }
                for (int j = 1; j <= (n - i); j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
