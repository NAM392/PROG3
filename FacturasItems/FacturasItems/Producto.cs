using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasItems
{
    class Producto
    {
        private string nombre;
        private string codigo;
        private string proveedor;
        private int stock;

        public Producto(string nombre, string codigo, string proveedor, int stock)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.proveedor = proveedor;
            this.stock = stock;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getCodigo()
        {
            return codigo;
        }

    }
}
