using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_Rectangle_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for(int i = 1; i <= n-1; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    if(i==1 || i==n-1 || j==1 || j==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
