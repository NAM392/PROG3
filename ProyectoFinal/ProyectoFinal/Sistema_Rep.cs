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
        private static List<Costeados> CalculoCosto;
        private static List<Costeados> ListaInvertida;
        private static List<Proveedor> Proveedores;

        //PONE EN MEMORIA A DEPOSITO , PROVEEDOR , COSTEADOS
         public  Sistema_Rep ()
        {
            Deposito = new List<Producto_comp>();
            Proveedores = new List<Proveedor>();
            CalculoCosto = new List<Costeados>();
        }
        //GETTER DEL DEPOSITO
        
        public  List<Producto_comp>  getDeposito()
        {
            return Deposito;

        }
        //GETTER DE COSTEADOS
        public List<Costeados> getCosteados()
        {
            return CalculoCosto;

        }

        //GETTER DE PROVEEDORES
        public List<Proveedor> getProveedor()
        {
            return Proveedores;
        }
        //QUITA UN PRODUCTO EN EL DEPOSITO
        public void ProductoVendido (Producto_comp vendido , int cantidad)
        {
            //si no hay mas producto se elimina del deposito
            if((vendido.cantidad - cantidad) <= 0)
            { Deposito.Remove(vendido); }
            else
            {
                string name = vendido.Nombre;
                int article = vendido.cod_articulo;
                Proveedor provider = vendido.Proveedor;
                int quant = cantidad;
                double cost = vendido.prec;
                DateTime fecha = vendido.date;
                Producto_comp prod = new Producto_comp(name, article, provider, quant, cost , fecha);
                Program.getSistema().agregarProducto(prod);
                Deposito.Remove(vendido);
            }

            
        }
        //AGREGA UN PRODUCTO EN EL DEPOSITO
        public void agregarProducto(Producto_comp agregar)
        {
            Costeados n = new Costeados(agregar.Nombre, agregar.prec, agregar.cantidad, agregar.date , agregar.Proveedor);
            CalculoCosto.Add(n);
            Deposito.Add(agregar);
          
        }
        //AGREGA UN PROVEEDOR
        public void agregarProveedor(Proveedor NewProv)
        {
            Proveedores.Add(NewProv);
        }
        //QUITAR UN PRODUCTO DEL DEPOSITO
        public void QuitarProducto(Producto_comp quit)
        {
            Deposito.Remove(quit);
        }
        //FUNCION CALCULAR FIFO
        public string FIFO(Producto_comp elegido)
        {
            //Ordena la Lista CalculoCosto por Fecha 
            CalculoCosto.Sort((x, y) => x.date.CompareTo(y.date));
            foreach (var c in CalculoCosto)
            {
                if (c.Nombre == elegido.Nombre)
                {
                    return (Math.Round(c.precio)).ToString();
                }
            }
            return "0";
        }
        //FUNCION CALCULAR LIFO
        public string LIFO(Producto_comp elegido)
        {
            //Ordena la Lista CalculoCosto por Fecha 
            CalculoCosto.Sort((x, y) => x.date.CompareTo(y.date));
            ListaInvertida = CalculoCosto;
            //Invierto CalculoCosto ya ordenada por Fecha 
            ListaInvertida.Reverse();

            foreach (var L in ListaInvertida)
            {
                if (L.Nombre == elegido.Nombre)
                {
                    return (Math.Round(L.precio)).ToString();
                }
            }

            return "0";
        }
        //FUNCION CALCULAR PPP
         public string PPP(Producto_comp elegido)
        {
            //Ordena la Lista CalculoCosto por Fecha 
            CalculoCosto.Sort((x, y) => x.date.CompareTo(y.date));
            int cont = 0;
            double acum = 0;


            foreach (var C in CalculoCosto)
            {
                if (C.Nombre == elegido.Nombre)
                {
                    acum += C.precio;
                    cont++;
                }
            }

            return (acum / cont).ToString();

            //return "0";
        }


    }
}

    

