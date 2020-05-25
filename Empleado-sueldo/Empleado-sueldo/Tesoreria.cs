using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Tesoreria
    {
        public void ImprimirPagos(IPagableMensual[] pagar, int mes)

        {

            foreach (IPagableMensual p in pagar)
            {
                Console.WriteLine(p.Descripcion() + "  " + p.Monto(mes));

            }


        }

        /*  Este es un ejemplo de sobrecarga de metodos , aca podemos ver dos metodos ImprimirPagos que obtienen dos parametros distindos
            el primero metodo que quiere que se le imprima deudas y se especifica el mes
            
             el segundo metodo con el unico parametro deudas imprime la sabana de deudas durante el año*/

        public void ImprimirPagos(IPagableMensual[] pagar)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("---Mes" + i);
                foreach (IPagableMensual p in pagar)
                {
                    if (p.Monto(i) > 0)
                    {

                        Console.WriteLine(p.Descripcion() + " " + p.Monto(i));

                    }
                }
            }
        }

        /*Se desea agregar a la clase Tesoreria un método que permita saber si cierto mes el resultado 
         * contable es positivo (ganancia) o negativo (pérdida).}
         * 
         * La idea es que dicho método 
         * reciba las obligaciones a pagar de la misma forma que el método ImprimirPagos que ya tenemos 
         * (un array). 
         * Además de "las cosas a pagar" recibirá "las cosas a cobrar" 
         * 
         * y producirá lo que se pide (resultado contable) en pantalla.*/

    
        public static void EstadoContable (aCobrar [] cobrar , aPagar [] pagar)
        {
            decimal[] meses = new decimal[12] { 0,0,0,0,0,0,0,0,0,0,0,0}; 

            foreach (aCobrar C in cobrar)
            {
                meses[C.month - 1] = C.amount + meses[C.month - 1];
            }

            foreach (aPagar P in pagar)
            {
                meses[P.month - 1] = meses[P.month - 1] - P.amount;

            }


            for(int i=0; i<12; i++)
            {
                if (meses[i] < 0 )
                {
                    Console.WriteLine(" EL MES N°" + (i+1) + " HUBO PERDIDA");
                }
                else if(meses[i] > 0)
                {
                    Console.WriteLine(" EL MES N°" + (i+1) + " HUBO GANANCIA ");
                }
                else
                {
                    Console.WriteLine("RESULTADO NULO");
                }
            }



        }








































    }
}
