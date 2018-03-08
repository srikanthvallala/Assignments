using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Operation");
            char c =Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case '+':
                    Console.WriteLine(a + b); 
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("invalid operation");
                    else
                        Console.WriteLine(a / b);
                    break;
                default :
                    //Console.WriteLine("selected operation is not listed");
                    break;

            }
            Console.ReadKey();
        }
    }
}
