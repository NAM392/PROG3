using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class BuscadorFacturas
    {
        private List<Factura> facturas;

        public BuscadorFacturas(List<Factura> facturas)
        {
            this.facturas = facturas;
        }

        public Factura ConNumeroDeFactura(int numero)
        {
            foreach (Factura f in facturas)
            {
                if (f.SosLaNumero(numero)) return f;
            }
            throw new FacturaNoEncontrada();
        }

        public List<Factura> ConProductoYCantidadMayorA(string codproducto, int cantidad)
        {
            List<Factura> aux = new List<Factura>();
            foreach (Factura f in facturas)
            {
                if (f.ContieneProductoConCodigo(codproducto) && f.CantidadProductoConCodigo(codproducto) > cantidad)
                {
                    aux.Add(f);
                }
            }
            return aux;
        }

    }
}
