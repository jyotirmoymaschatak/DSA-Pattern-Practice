using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
            int n = 4;
            for (int line = 1; line <= n; line++)
            {
                for (int j = 1; j <= line; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
