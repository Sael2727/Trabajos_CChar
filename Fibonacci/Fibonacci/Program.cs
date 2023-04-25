using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, primero = 0, segundo = 1, s;
            Console.WriteLine("Digite el valor de n: ");
            n= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i=0; i < n; i++)
            {
                if (i <= 1)
                {
                    s= i;
                }
                else
                {
                    s = primero +segundo;
                    primero = segundo;
                    segundo = s;
                }
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
