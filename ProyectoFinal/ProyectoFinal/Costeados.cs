using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Costeados
    {
        private string name;
        private int quantity;
        private double price_un;
        private DateTime Fecha;
        private Proveedor proveed;
        public Costeados(string nombre , double precio_unidad , int cantidad , DateTime fecha , Proveedor proveedor)
        {
            name = nombre;
            quantity = cantidad;
            price_un = precio_unidad;
            Fecha = fecha;
            proveed = proveedor;
        }

        public string Nombre
        {
            get { return name; }
        }

        public int cantidad
        {
            get { return quantity; }
        }

        public double precio
        {
            get { return price_un; }
        }
        public DateTime date
        {
            get { return Fecha; }
        }
        public Proveedor Proveedor
        {
            get { return proveed; }
        }
        public override string ToString()
        {
            return "     Nombre : " + Nombre + "    Cantidad :  " +  cantidad + "     Precio :  $" +  precio + "    Fecha :  " + date.ToShortDateString() ;
        }

    }
}
