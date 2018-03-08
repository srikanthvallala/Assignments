using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of array a");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array a");
            int[] a = new int[l];
            for (int i = 0; i < l; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int b =0;
            for (int i = 0; i < l; i++)
            {
                if (a[i] % 2 != 0)
                    b++;
            }
            if (b > 0)
                Console.Write("True");
            else
                Console.Write("false");
            Console.ReadKey();
        }
    }
}
