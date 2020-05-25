using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTADISTICA
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingreso;
            double ACUM = 0;
            Double Promedio = 0;
            Double[] ENTRADA = new double[5];
            Double SUMA_DIF = 0;
            Double VARIANZA = 0;
            Double DESVIO_ESTANDARD = 0;
            

            Console.WriteLine("Ingrese 5 valores");
            for (int i = 0; i < 5; i++)
            {
                ingreso = Console.ReadLine();
                ACUM = Double.Parse(ingreso) + ACUM;
                ENTRADA[i] = Double.Parse(ingreso);
            }
            Promedio = ACUM / 5;
            for (int i = 0; i < 5; i++)
            {
                SUMA_DIF = Math.Pow((Promedio - ENTRADA[i]), 2) + SUMA_DIF;
            }

            VARIANZA = SUMA_DIF / 5;
            DESVIO_ESTANDARD = Math.Sqrt(VARIANZA);

            Console.WriteLine("El promedio es {0} , La varianza es {1} y el desvio estandard es {2} ", Promedio, VARIANZA,Math.Round( DESVIO_ESTANDARD , 3));
            //   Redondeo atras de la coma con Math.Round( variable DOUBLE , cantidad de numeros atras de la coma) 
            Console.ReadKey();
        }
    }
}