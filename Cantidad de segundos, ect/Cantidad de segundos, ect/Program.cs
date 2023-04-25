using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantidad_de_segundos__ect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double AFP, ARS, ISR, sueldo_b, sueldo_n;
            double total_de_descuento;
            string nombre, apellido, cedula;
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("PROCESO " + i);
                Console.Write("Ingresa el nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingresa el apellido: ");
                apellido = Console.ReadLine();
                Console.Write("Ingresa el cedula: ");
                cedula = Console.ReadLine();
                Console.Write("Ingresa el valor de sueldo b: ");
                sueldo_b = double.Parse(Console.ReadLine());
                if (sueldo_b >= 20000)
                {
                    ISR = sueldo_b * 0.085;
                    ARS = sueldo_b * 0.075;
                    AFP = sueldo_b * 0.065;
                }
                else
                {
                    ISR = sueldo_b * 0.07;
                    ARS = sueldo_b * 0.06;
                    AFP = sueldo_b * 0.05;
                }
                total_de_descuento = ISR + ARS + AFP;
                sueldo_n = sueldo_b - total_de_descuento;
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Cedula: " + cedula);
                Console.WriteLine("Valor de AFP: " + AFP);
                Console.WriteLine("Valor de ARS: " + ARS);
                Console.WriteLine("Valor de ISR: " + ISR);
                Console.WriteLine("Valor de sueldo n: " + sueldo_n);
                Console.WriteLine("Valor de total de descuento: " + total_de_descuento);
                Console.WriteLine();

            }
    }
}
