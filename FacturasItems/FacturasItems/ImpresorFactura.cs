using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    static class ImpresorFactura
    {
        static public void Imprimir(Factura factura) 
        {
            Console.WriteLine("\nFACTURA #" + factura.getNumero());
            Console.WriteLine("----------------------------------");

            string[] lineas = factura.getItemsParaImprimir();
            foreach(string s in lineas) {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total factura: $" + factura.getTotal() );
            Console.WriteLine("==================================");
        }

        static public void Imprimir(List<Factura> facturas)
        {
            foreach (Factura f in facturas)
            {
                Imprimir(f);
            }
        }


    }
}
