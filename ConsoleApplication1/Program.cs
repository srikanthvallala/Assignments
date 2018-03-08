using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = n1 * n2;
            Console.WriteLine(n3);

            //Console.WriteLine("entered number is" + n1);
            Console.ReadKey();
        }
    }
}
