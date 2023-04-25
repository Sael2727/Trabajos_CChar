using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(5));
            Console.ReadLine(); 
        }
        public static int Suma(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Suma(n-1);

            }
           
        }
       
    }
}
