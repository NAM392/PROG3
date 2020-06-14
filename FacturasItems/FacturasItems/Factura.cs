using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class Factura
    {
        private int numero;
        private List<Item> items;

        public Factura(int numero)
        {
            this.numero = numero;
            items = new List<Item>();
        }

        public void agregarItem(Producto producto, decimal precio, int cantidad)
        {
            Item i = new Item(producto: producto, precio: precio, cantidad: cantidad);
            items.Add(i);
        }

        public string[] getItemsParaImprimir()
        {
            string[] aux = new string[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                aux[i] = items[i].getProducto().getNombre() + ": " + items[i].getCantidad() + " x $" + items[i].getPrecioUnitario() + " = $" + items[i].getPrecioTotal();
            }
            return aux;
        }

        public int getNumero()
        {
            return numero;
        }

        public decimal getTotal()
        {
            decimal aux = 0;
            foreach (Item i in items)
            {
                aux += i.getPrecioTotal();
            }
            return aux;
        }

        public int CantidadProductoConCodigo(string codproducto)
        {
            int cant = 0;
            foreach (Item i in items)
            {
                if (i.EsProductoConCodigo(codproducto)) cant+=i.getCantidad();
            }
            if (cant == 0) throw new ProductoNoEncontrado();
            return cant;
        }

        public bool ContieneProductoConCodigo(string codproducto)
        {
            foreach (Item i in items)
            {
                if (i.EsProductoConCodigo(codproducto)) return true;
            }
            return false;
        }

        public bool SosLaNumero(int numero)
        {
            if (this.numero == numero) return true;
            else return false;
        }
    }

    class ProductoNoEncontrado : Exception { }
}
