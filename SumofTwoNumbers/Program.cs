using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int c = a + b;
            if (a == b)
                Console.WriteLine(c * 3);
            else
                Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
