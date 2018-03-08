using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatestof3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number c");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a >b)
            {
                if (a > c)
                    Console.WriteLine("greatest of 3 numbers is" + a);
                else
                    Console.WriteLine("greatest of 3 numbers is" + c);
            }
            else if (b>c)
                Console.WriteLine("greatest of 3 numbers is" + b);
            else
                Console.WriteLine("greatest of 3 numbers is" + c);

            Console.ReadKey();
        }
    }
}
