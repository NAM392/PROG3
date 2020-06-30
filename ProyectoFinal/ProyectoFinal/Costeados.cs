using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    [Serializable]
    class Costeados
    {
        //CLASE DE PRODUCTOS (AUXILIAR DE Producto_Comp PARA PODER COSTEAR LOS PRODUCTOS INGRESADOS)
        private string name;
        private int quantity;
        private double price_un;
        private DateTime Fecha;
        private int codigo;
        private Proveedor proveed;
        public Costeados(string nombre , int cod_art ,  double precio_unidad , int cantidad , DateTime fecha , Proveedor proveedor)
        {
            name = nombre;
            quantity = cantidad;
            price_un = precio_unidad;
            Fecha = fecha;
            proveed = proveedor;
            codigo = cod_art;
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
        public int cod_articulo
        {
            get { return codigo; }
        } 
        public override string ToString()
        {
            return "     Nombre : " + Nombre +"    Codigo: " + codigo + "    Cantidad :  " +  cantidad + "     Precio :  $" +  precio + "    Fecha :  " + date.ToShortDateString() ;
        }

    }
}
