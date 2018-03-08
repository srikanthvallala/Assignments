using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            int b =0;
            while(a>0)
            {
                b = b + (a % 10);
                a = a / 10; 
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
