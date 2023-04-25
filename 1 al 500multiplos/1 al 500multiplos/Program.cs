using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_al_500multiplos
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(" CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\n" +
          " NOMBRE : SAEL GERMAN GARCIA\n " +
          " NO.ORDEN: 11\n " +
          " PROFESOR: JOSE SIERRA " +
           " Imprimir los números del 1 al 500 que solo sean múltiplos del 3 y 5. (2 P)*/");
           
            
            for (int numeros=0; numeros < 500; numeros += 15)
            {
                

                    Console.WriteLine(numeros);


                }
            
            Console.ReadKey();
        }
    }
}
