using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    [Serializable]
    class Producto_comp
    {

        private string name;
        private int CodArt;
        private Proveedor proveedor;
        private int quantity;
        private double price_un;
        private DateTime Fecha;

        public Producto_comp (string nombre , int codigo_art , Proveedor prov , int cantidad , double precio_unidad , DateTime fecha)
        {
            name = nombre;
            CodArt = codigo_art;
            proveedor = prov;
            quantity = cantidad;
            price_un = precio_unidad;
            Fecha = fecha;
        }

        public string Nombre
        {
             get { return name; }
        }
        public int cod_articulo
        {
            get { return CodArt; }
        }
        public Proveedor Proveedor
        {
            get { return proveedor; }
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
        public override string ToString()
        {
            return Nombre ;
            
        }
    }
}
