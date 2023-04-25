using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Hasta_el_9_999
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine(" CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA" +
          " NOMBRE : SAEL GERMAN GARCIA " +
          " NO.ORDEN: 11 " +
          " PROFESOR: JOSE SIERRA " +
          " Haciendo uso de DO WHILE: escribir un programa que ingrese un valor del " +
          " 1 hasta el 9,999. El programa debe decir de cuantas cifras en el valor " +
          " ingresado. Finalizar el programa si el usuario ingresa cualquier número " +
          " negativo. (10 P)");

            int contador;
            string linea;
            do
            {
                Console.Write("Ingrese un valor del 1 hasta el  9,999 (con numero negativo finaliza):");
                linea = Console.ReadLine();
                contador = int.Parse(linea);
               
                if (contador >= 1000)
                {
                    Console.WriteLine("Tiene 4 cifras.");
                   
                }
                 else if (contador >= 100)
                {
                    Console.WriteLine("Tiene 3 cifras.");
                }



                else 
                {
                    {
                        if (contador >= 10)
                        {
                            Console.WriteLine("Tiene 2 cifras.");
                        }
                        else
                        {
                            Console.WriteLine("Tiene 1 cifra.");
                        }
                    }
                }
            } while (contador > 0);

        }
    }

 }

