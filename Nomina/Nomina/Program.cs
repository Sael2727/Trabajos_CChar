using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\n" +
          " NOMBRE : SAEL GERMAN GARCIA\n " +
          " NO.ORDEN: 11\n " +
          " PROFESOR: JOSE SIERRA " +
          "Haciendo uso de VECTORES, CICLOS entre otros, realizar una nomina \nde\npago para 10 empleados donde se reflejen todos los cálculos y los\r\ndescuentos de ley. Ver imagen. (20 P)");

            int c = 1;
            String[] nombres = new string[c];
            double[] Sueldo = new double[c];
            double[] AFP = new double[c];
            double[] SFS = new double[c];
            double[] ISR = new double[c];
            double[] Td = new double[c];
            double[] Sueldoneto = new double[c];
            double[] Sn1 = new double[c];
            double[] Suanual = new double[c];
            double[] Exedente = new double[c];
            double[] Descuento = new double[c];
            
            // Montos
            double Monto_Fijo1 = 31216;
            double Monto_Fijo2 = 79776;
            
            //Escalas
            double Escala1 = 416220;
            double Escala2 = 624329;
            double Escala3 = 867123;



            for (int a = 0; a < c; a++)
            {
                Console.Write("Ingrese el nombre del empleado: " + (a + 1));
                nombres[a] = Console.ReadLine();

                Console.Write("Ingrese el Sueldo Bruto: " + (a + 1));
                Sueldo[a] = Convert.ToInt32(Console.ReadLine());

                double valor1 = 0.0287;
                AFP[a] = Sueldo[a] * valor1;


                double valor2 = 0.0304;
                SFS[a] = Sueldo[a] * valor2;

                Descuento[a] = AFP[a] + SFS[a];
             


            }
            Console.Clear();
            for (int a = 0; a < c; a++)
            {

                double valor1 = 0.0287;
                AFP[a] = Sueldo[a] * valor1;


                double valor2 = 0.0304;
                SFS[a] = Sueldo[a] * valor2;


                Td[a] = AFP[a] + SFS[a];


                Suanual[a] = Sueldo[a] - Td[a];


            }
            Console.Clear();

            for (int a = 0; a < c; a++)
            {
                if ((Sueldo[a]-Descuento[a]) * 12 > Escala1 && (Sueldo[a] - Descuento[a]) * 12 < Escala2)
                {

                    double valor1 = 0.0287;
                    AFP[a] = Sueldo[a] * valor1;


                    double valor2 = 0.0304;
                    SFS[a] = Sueldo[a] * valor2;



                    Td[a] = AFP[a] + SFS[a];

                    Sueldoneto[a] = Sueldo[a] - Td[a];

                    Suanual[a] = Sueldoneto[a] * 12;

                    Exedente[a] = Suanual[a] - Escala1;


                    ISR[a] = (Exedente[a] * 0.15) / 12;

                    Sueldoneto[a] = Sueldoneto[a] - ISR[a];
                    Td[a] = Td[a] + ISR[a];

                }
                Console.Clear();


                if ((Sueldo[a] - Descuento[a]) * 12 > Escala2 && (Sueldo[a] - Descuento[a]) * 12 < Escala3)
                {
                    double valor1 = 0.0287;
                    AFP[a] = Sueldo[a] * valor1;

                    double valor2 = 0.0304;
                    SFS[a] = Sueldo[a] * valor2;

                    Td[a] = AFP[a] +SFS[a];

                    Sn1[a] = Sueldo[a] - Td[a];

                    Suanual[a] = Sn1[a] * 12;

                    Exedente[a] = Suanual[a] - Escala2;

                    ISR[a] = ((Exedente[a] * 0.20) + Monto_Fijo1) / 12;

                    Sueldoneto[a] = Sn1[a] - ISR[a];

                    Td[a] = Td[a] + ISR[a];


                }
                Console.Clear();

                if ((Sueldo[a] - Descuento[a]) * 12 > Escala3)
                {

                    double valor1 = 0.0287;
                    AFP[a] = Sueldo[a] * valor1;

                    double valor2 = 0.0304;
                    SFS[a] = Sueldo[a] * valor2;

                    Td[a] = AFP[a] + SFS[a];

                    Sn1[a] = Sueldo[a] - Td[a];

                    Suanual[a] = Sn1[a] * 12;

                    Exedente[a] = Suanual[a] - Escala3;

                    ISR[a] = ((Exedente[a] * 0.25) + Monto_Fijo2) / 12;

                    Sueldoneto[a] = Sn1[a] - ISR[a];

                    Td[a] = Td[a] + ISR[a];

                    Console.Clear();

                }



                for (int i = 0; i < c; i++)


                {


                    Console.WriteLine("Empleado :{0}| S_B:{1} |  AFP {2} | SFS {3} | ISR {4}  |Total_Desc {5}|Sueldo_N {6}"
                                     , nombres[i], Sueldo[i], AFP[i], SFS[i], ISR[i], Td[i], Sueldoneto[i]);


                }



                Console.ReadKey();
            }

        }
    }
}