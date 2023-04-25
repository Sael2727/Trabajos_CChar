using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\n" +
          " NOMBRE : SAEL GERMAN GARCIA\n " +
          " NO.ORDEN: 11\n " +
          " PROFESOR: JOSE SIERRA " +
           "Utilizando FOR, crear un programa que cargue 5 \ncalificaciones de un alumno" +
            "por teclado y nos muestre el promedio. ¡Si el\n promedio es mayor o igual a" +
            "80 el programa debe decir: promovido\n exitosamente!, en caso contrario" +
            "debe decir: ¡Reprobado! (10 P )*/");

            Console.WriteLine("Ingresar el nombre del estudiante:");
            string nombre=(Console.ReadLine());

            double calificacion, suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Introduce la " + i + " Calificacion:");
                calificacion = Convert.ToInt32(Console.ReadLine());
                suma += calificacion;

            }
            double promedio;
            promedio = suma / 5;
           
            if (promedio >= 80)
            {

                Console.WriteLine("promovido exitosamente " + promedio);
            }
            else
            {

                Console.WriteLine("Reprovado " + promedio);
            }
            Console.ReadKey();
        }

    }
}
            

        
        

    

