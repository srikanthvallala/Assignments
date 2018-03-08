using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of array a");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array a");
            int[] a = new int[l];
            for (int i = 0; i <l; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int s = 0;
            for (int i = 0; i < l; i++)
            {
                s = s + a[i];
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
