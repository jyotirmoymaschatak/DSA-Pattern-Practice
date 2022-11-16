using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunal_DSA_Pattern_No_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                for (int j = 1; j <= 2*(n-i); j++)
                    Console.Write(" ");
                for (int j = i; j >= 1; j--)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
