using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_facturas
{
    class ImpresorFactura : Sistema
    {
        static public void Imprimir(Factura factura) 
        {
            
            foreach(var F in Facturas)
            {
                if (F == factura)
                {
                    Console.WriteLine("\n\n\t\tFACTURA N° : {0}", F.n_factura);
                    Console.WriteLine("\n\t\t*******************");
                    double m=0;//variable para el monto
                    double monto=0;
                    foreach(var it in F.Items)
                    {
                        foreach(KeyValuePair<string,string> COD in it.Product)
                        {
                            Console.WriteLine("\t\t" + COD.Key + " X " + it.quantity +  " = $ " +  (m = (it.precio * it.quantity)));
                            monto = monto + m;

                        }

                    }
                    Console.WriteLine("\n\t\t ** TOTAL : $ {0}", monto);
                    Console.WriteLine("\n\t\t*******************\n\n");

                }

            }

        }

        /***    SOBRECARGA DE METODOS   ****/
        static public void Imprimir(List<Factura> ff)
        {
            for(int i = 0; i< ff.Count; i++)
            {
                foreach (var F in Facturas)
                {
                    if (F == ff[i])
                    {
                        Console.WriteLine("\n\n\t\tFACTURA N° : {0}", F.n_factura);
                        Console.WriteLine("\n\t\t*******************");
                        double m = 0;//variable para el monto
                        double monto = 0;
                        foreach (var it in F.Items)
                        {
                            foreach (KeyValuePair<string, string> COD in it.Product)
                            {
                                Console.WriteLine("\t\t" + COD.Key + " X " + it.quantity + " = $ " + (m = (it.precio * it.quantity)));
                                monto = monto + m;
                            }

                        }
                        Console.WriteLine("\n\t\t ** TOTAL : $ {0}", monto);
                        Console.WriteLine("\n\t\t*******************\n\n");

                    }

                }

            }

    }



























}
}
