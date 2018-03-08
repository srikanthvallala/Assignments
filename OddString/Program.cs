using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string a = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(a.Length);
            string b = null;
            for (int i = 0; i<= a.Length ; i++)
            {
                
                if (i% 2 == 0)
                        b = b + a[i];
            }


            Console.Write(b);
            Console.ReadKey();
        }
    }
}
