using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_facturas
{
    class Item
    {
        
        private Dictionary<string, string> PR;
        private int cant;
        private double price;
        private double amounth;

        public Item(Dictionary<string, string> producto, int cantidad, double precio , double monto)
        {
            PR = producto;
            cant = cantidad;
            price = precio;
            amounth = monto;

        }
        public Dictionary<string, string> Product
        {
            get { return PR; }
        }
        public int quantity
        {
            get { return cant; }
        }
        public double precio
        {
            get { return price; }
        }
        public double total
        {
            get { return amounth; }
        }

    }
}
