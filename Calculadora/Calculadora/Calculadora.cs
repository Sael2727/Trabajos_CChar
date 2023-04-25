using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        //Declaramos los atributos
        public double a;
        public double b;
        public double r;

        // Declaramos los metodos
        public void SUMAR()
        {
            //Se lleva a cabo una accion 
            r = a + b;
        }
        public void Muestra()
        {
            Console.WriteLine("a={0},b={1},c={2}", a, b, r);
        }
    }

}
