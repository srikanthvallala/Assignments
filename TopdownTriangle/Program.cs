using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopdownTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i< 6 ;i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.Write("\n");
            }
            Console.ReadKey();
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.Write("\n");
            }
            Console.ReadKey();

            for (int i = 1; i < 6; i++)
            {
                int n = 1;
                for (int j = 1; j <= i; j++)
                { Console.Write(n);
                    n=n+j;
                }

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
