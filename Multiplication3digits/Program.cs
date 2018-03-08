using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication3digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = n1 * n2 * n3;
            Console.WriteLine(n4);
            Console.ReadKey();
        }
    }
}
