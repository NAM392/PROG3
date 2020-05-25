using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_facturas
{
    class Program
    {

        static void Main(string[] args)
        {


            Sistema.Inicializar();


            // a) Dado un número de factura mostrar en pantalla los ítems que la componen y el total
            // Factura F = Sistema.getFactura(numero: 238);
            //  ImpresorFactura.Imprimir(factura: F);


            // EXCEPCION
            //  Factura faux = Sistema.getFactura(numero: 888);


            //    b) Dado un código de ítem mostrar las facturas en las que está presente en más de 5 unidades
            //ImpresorFactura.Imprimir(Sistema.FacturasConProductoYCantidadMayorA(codproducto: "TU", cantidad: 5));



            // c) Mostrar en pantalla las facturas que tengan algún item del proveedor "Gomez S.A." y cuyo stock sea menor a 2
            // ImpresorFactura.Imprimir(Sistema.FacturasporProveedoryStock(proveedor: "Gomez S.A.", stock : 2));


            //d) Mostrar en pantalla la/ s factura / s con monto mayor
             ImpresorFactura.Imprimir(Sistema.MontoMayorA(monto:200));

















            /*
            //-----punto a del enunciado
            Console.WriteLine("punto a) imprimir factura por código");
            Factura f = Sistema.getFactura( numero: 1);
            ImpresorFactura.Imprimir(factura: f);

            //la línea siguiente debe fallar, comentada para que el programa siga
            //Factura faux = Sistema.getFactura(numero: 888); //esto tiene que darme una excepcion

            //-----punto b del enunciado
            Console.WriteLine("\n\npunto b) imprimir facturas con más de 5 tuercas");
            ImpresorFactura.Imprimir(Sistema.FacturasConProductoYCantidadMayorA(codproducto: "TU", cantidad: 5));


            //-----a terminar: puntos c y d
            */

            try { Sistema.getFactura(888); }
            catch (Factura_Inexistente obj1)
            {
                Console.WriteLine("factura inexistente");
            }

            Console.ReadKey();


        }
    }
}




/*Se desea diseñar un sistema orientado a objetos para facturación de una empresa.
Las facturas están compuestas de ítems que forman un total a pagar.
Los ítems que se venden son a su vez provistos a la empresa por un proveedor.

El sistema tiene que poder responder a los siguientes mensajes:

a) Dado un número de factura mostrar en pantalla los ítems que la componen y el total

b) Dado un código de ítem mostrar las facturas en las que está presente en más de 5 unidades

c) Mostrar en pantalla las facturas que tengan algún item del proveedor "Gomez S.A." y cuyo stock sea menor a 2

d) Mostrar en pantalla la/s factura/s con monto mayor

*/
