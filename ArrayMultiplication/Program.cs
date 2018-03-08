using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array a");
            int[] a= new int[5];
            for (int i=0; i<=4 ; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            
            Console.WriteLine("enter array b");
            int[] b = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(b[i]);
            }

            int[] c = new int[5];
            for (int i = 0; i<5; i++)
            {

                c[i] = a[i] * b[i];
                Console.WriteLine(c[i]);
            }

            Console.ReadKey();
        }

    }
}
