using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creeamos instancia
            Calculadora Cal1= new Calculadora();

            // accedemos a los atributos para colocar informacion
            Cal1.a=5;
            Cal1.b=3;

            //Mostramos los datps
            Cal1.Muestra();

            // invocamos metodo
            Cal1.SUMAR();

            //Mostramos nuevamente los datos

            Cal1.Muestra();
            Console.WriteLine("-----------------------------");

            //Creemos otro objeto y asignamos valores
            Calculadora Cal2= new Calculadora();

            Cal2.a = 18;
            Cal2.b = 53;
            Cal2.SUMAR();

            //Comprobamos que cada objeto tiene su propia informacion

            Cal1.Muestra();
            Cal2.Muestra(); 




            Console.ReadLine();
            //
        }
    }
}
