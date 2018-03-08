using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = null;
            double b = 0.0;
            Console.WriteLine("enter value for n");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                b = b + (1 / (float)i);
                if( i!=n )
                 sum = sum+("1/" + i + "+");
                else
                    sum = sum + ("1/" + i);
            }
            Console.WriteLine(b);
            Console.WriteLine(sum + " = " + b);
            Console.ReadKey();
        }
    }
}
