using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema.Inicializar();

            #region -----punto a del enunciado
            Console.WriteLine("punto a) imprimir factura por código");
            Factura f = Sistema.getFactura(numero: 1);
            ImpresorFactura.Imprimir(factura: f);

            //la línea siguiente debe fallar, comentada para que el programa siga
            //Factura faux = Sistema.getFactura(numero: 888);
            #endregion

            #region -----punto b del enunciado
            Console.WriteLine("\n\npunto b) imprimir facturas con más de 5 tuercas");
            ImpresorFactura.Imprimir(Sistema.FacturasConProductoYCantidadMayorA(codproducto: "TU", cantidad: 5));
            #endregion

            //-----a terminar: puntos c y d
        }
    }
}
