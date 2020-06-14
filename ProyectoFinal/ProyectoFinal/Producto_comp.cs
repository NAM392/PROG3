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
        private int CodProv;
        private int quantity;
        private double price_un;

        public Producto_comp (string nombre , int codigo_art , int codigo_prov , int cantidad ,double precio_unidad)
        {
            name = nombre;
            CodArt = codigo_art;
            CodProv = codigo_prov;
            quantity = cantidad;
            price_un = precio_unidad;

        }

        public string Nombre
        {
             get { return name; }
        }
        public int cod_a
        {
            get { return CodArt; }
        }
        public int cod_p
        {
            get { return CodProv; }
        }
        public int cant 
        {
            get { return quantity; }
        }

        public double prec
        {
            get { return price_un; }
        }
        public override string ToString()
        {

            return Nombre;

        }














    }
}
