using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    [Serializable]
    class Sistema_Rep
    {
        /*CLASE SISTEMA QUE CONTIENE EL DEPOSITO Y LOS METODOS PARA LOS DIFERENTES CALCULOS*/

        private static List<Producto_comp> Deposito;
        private static List<Producto_comp> PG;


        //PONE EN MEMORIA A DEPOSITO
        public Sistema_Rep ()
        {
            Deposito = new List<Producto_comp>();
        }
        //GETTER DEL DEPOSITO
        public  List<Producto_comp>  getSistema()
        {
            return Deposito;
        }
        //QUITA UN PRODUCTO EN EL DEPOSITO
        public void ProductoVendido (Producto_comp vendido)
        {
            Deposito.Remove(vendido);
        }
        //AGREGA UN PRODUCTO EN EL DEPOSITO
        static public void agregarProducto(Producto_comp agregar)
        {
            Deposito.Add(agregar);
        }
        //FUNCION CALCULAR FIFO
        static public string FIFO(Producto_comp elegido)
        {
             PG = Deposito;

            foreach (var p in PG)
            {
                if (p.Nombre == elegido.Nombre)
                {
                    return (Math.Round(p.prec)).ToString();
                }
            }
            return "0";
        }
        //FUNCION CALCULAR LIFO
        static public string LIFO(Producto_comp elegido)
        {
            PG = Deposito;

            PG.Reverse();

            foreach (var p in PG)
            {
                if (p.Nombre == elegido.Nombre)
                {
                    return (Math.Round(p.prec)).ToString();
                }
            }

            return "0";
        }
        //FUNCION CALCULAR PPP
        static public string PPP(Producto_comp elegido)
        {

            PG = Deposito; 
            int cont = 0;
            double acum = 0;


            foreach (var p in PG)
            {
                if (p.Nombre == elegido.Nombre)
                {
                    acum += p.prec;
                    cont++;
                }
            }

            return (acum / cont).ToString();

            //return "0";
        }


    }
}

    

