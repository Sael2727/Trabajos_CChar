using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_e_egresos
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\n" +
          " NOMBRE : SAEL GERMAN GARCIA\n " +
          " NO.ORDEN: 11\n " +
          " PROFESOR: JOSE SIERRA " + " El Centro Comercial CEPVA C X A requiere llevar el control \n" +
          "de los ingresos y " +
            "egresos de la empresa.Se solicita un programa que acumule dichos ingresos\n " +
            "y retiros, que contabilice o cuente la cantidad de cada uno e imprima sus\n " +
            " resultados.Además, debe decir si el balance es acreedor o deudor.El\n " +
            "programa debe terminar su ejecución si el usuario escribe el código 0011\n " +
          " (10 P)\n");
            double movimiento = 0;
            double Balance = 0;
            string Codigo = "";

            int Contador_ingr = 0;
            int egresos = 0;

            int acomulacion;
            while (Codigo != "0011")
            {
                Console.WriteLine("\n Ingresar Codigo de movimiento:\n\n 1-ingresar \n 2-egresar \n 3-Mostrar cuenta \n 0011-exit \n");
                Codigo = Console.ReadLine();

                if (Codigo == "1")
                {
                    Console.Write("\n Ingrese el Monto de movimiento:");
                    movimiento = double.Parse(Console.ReadLine());
                    Balance += movimiento;
                    Contador_ingr++;

                }
                if (Codigo == "2")
                {
                    Console.Write("\n Ingrese el Monto de movimiento:");
                    movimiento = double.Parse(Console.ReadLine());   
                    Balance -= movimiento;
                    egresos++;

                }

                if (Codigo == "3")
                {
                    acomulacion = Contador_ingr;

                    Console.WriteLine($"Numero de igresos: {Contador_ingr}");
                    Console.WriteLine($"Numero de egresos:{egresos}");
                    Console.WriteLine($"Dinero egresado:{movimiento}");





                    if (Balance > 0)
                    {
                        Console.WriteLine($"\n Balance: {Balance}");
                        Console.WriteLine("la empresa es acreedora.");


                    }
                    else if (Balance < 0)
                    {
                        Console.WriteLine($"Deuda: {Balance}");
                        Console.WriteLine("La empresa es deudora.");
                    }
                    else
                    {
                        Console.WriteLine("La empresa tiene balance cero");
                    }
                }

            }
        }
    }
}
























































