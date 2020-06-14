using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class Sistema
    {
        static private List<Factura> facturas;

        static public void Inicializar()
        {
            facturas = new List<Factura>();

            Producto p1 = new Producto(nombre: "Tornillo", codigo:"TOR", proveedor: "Gomez SA", stock: 30);
            Producto p2 = new Producto(nombre: "Tuerca", codigo: "TU", proveedor: "Gomez SA", stock: 1);
            Producto p3 = new Producto(nombre: "Arandela", codigo: "ARA", proveedor: "Fernandez", stock: 10);

            Factura f1 = new Factura(numero: 1);
            f1.agregarItem(producto: p1, precio: 10.8m, cantidad: 10);
            f1.agregarItem(producto: p2, precio: 5.5m, cantidad: 10);
            f1.agregarItem(producto: p3, precio: 6.6m, cantidad: 2);
            facturas.Add(f1);

            Factura f2 = new Factura(numero: 2);
            f2.agregarItem(producto: p1, precio: 10.8m, cantidad: 4);
            f2.agregarItem(producto: p2, precio: 5.5m, cantidad: 4);
            facturas.Add(f2);

            Factura f3 = new Factura(numero: 3);
            f3.agregarItem(producto: p2, precio: 5.5m, cantidad: 4);
            f3.agregarItem(producto: p2, precio: 5.5m, cantidad: 2);
            facturas.Add(f3);
        }

        public static Factura getFactura(int numero)
        {
            var busq = new BuscadorFacturas(facturas);
            return busq.ConNumeroDeFactura(numero);
        }

        public static List<Factura> FacturasConProductoYCantidadMayorA(string codproducto, int cantidad)
        {
            var busq = new BuscadorFacturas(facturas);
            return busq.ConProductoYCantidadMayorA(codproducto, cantidad);
        }
    }

    class FacturaNoEncontrada : Exception { }
}
