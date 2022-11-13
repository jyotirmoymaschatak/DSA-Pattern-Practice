using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
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
                int count = 1;

                while(count<=(i))
                {
                    Console.Write(i+ " ");
                    count++;
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
