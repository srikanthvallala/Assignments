using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i =width; i>0; i--)
            {
                for (int j = i; j > 0; j--)
                    Console.Write(num);
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
