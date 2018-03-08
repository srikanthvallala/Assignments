using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPassRange
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number between 1 to 100");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n <= 100)
            {
                if (n < 35)
                    Console.WriteLine("Fail");
                else
                    Console.WriteLine("Pass");
            }
            else
                Console.WriteLine("given value is out of range");
            Console.Read();
                


        }
    }
}
