using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class Item
    {
        private Producto producto;
        private decimal precio;
        private int cantidad;

        public Item(Producto producto, decimal precio, int cantidad)
        {
            this.producto = producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public Producto getProducto() { return producto; }
        public decimal getPrecioUnitario() { return precio; }
        public decimal getPrecioTotal() { return precio * cantidad; }
        public int getCantidad() { return cantidad; }


        public bool EsProductoConCodigo(string codproducto)
        {
            if (producto.getCodigo() == codproducto) return true;
            else return false;
        }
    }
}
