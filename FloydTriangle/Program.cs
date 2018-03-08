using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter height of tiangle");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<= n; i++)
            {
                if(i%2 != 0)
                    for(int j=1;j<= i;j++)
                    {
                        Console.Write(j % 2);
                    }
                else
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write((j+1) % 2);
                    }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
