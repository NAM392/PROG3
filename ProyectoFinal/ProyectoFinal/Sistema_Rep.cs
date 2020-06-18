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
         public  Sistema_Rep ()
        {
            Deposito = new List<Producto_comp>();
        }
        //GETTER DEL DEPOSITO
        
        public  List<Producto_comp>  getDeposito()
        {
            return Deposito;
        }
        

        //QUITA UN PRODUCTO EN EL DEPOSITO
        public void ProductoVendido (Producto_comp vendido , int cantidad)
        {
            //si no hay mas producto se elimina del deposito
            if((vendido.cant - cantidad) <= 0)
            { Deposito.Remove(vendido); }
            else
            {
                string name = vendido.Nombre;
                int article = vendido.cod_a;
                int provider = vendido.cod_p;
                int quant = cantidad;
                double cost = vendido.prec;
                Producto_comp prod = new Producto_comp(name, article, provider, quant, cost);
                Program.getSistema().agregarProducto(prod);
                Deposito.Remove(vendido);
            }

            
        }
        //AGREGA UN PRODUCTO EN EL DEPOSITO
         public void agregarProducto(Producto_comp agregar)
        {
            Deposito.Add(agregar);
        }
        //FUNCION CALCULAR FIFO
        public string FIFO(Producto_comp elegido)
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
        public string LIFO(Producto_comp elegido)
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
         public string PPP(Producto_comp elegido)
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

    

