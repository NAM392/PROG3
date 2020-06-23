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
        private static Dictionary<string, string> Ingresos;

        //PONE EN MEMORIA A DEPOSITO , PROVEEDOR , COSTEADOS
        public Sistema_Rep()
        {
            Deposito = new List<Producto_comp>();
            Proveedores = new List<Proveedor>();
            CalculoCosto = new List<Costeados>();
            Ingresos = new Dictionary<string, string>();
        }
        //GETTER DEL DEPOSITO

        public List<Producto_comp> getDeposito()
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
        //Getter de ingresos
        public Dictionary<string, string> getIngresos()
        {
            return Ingresos;

        }
        //VERIFICA USUARIO Y CONTRASEÑA
        public bool VerificaUsuarioyPass(string usuario, string password)
        {
            foreach (KeyValuePair<string, string> d in Ingresos)
            {
                if (d.Key == usuario && d.Value == password)
                {
                    return true;
                }
            }
            return false;
        }
        //QUITA UN PRODUCTO EN EL DEPOSITO
        public void ProductoVendido(Producto_comp vendido, int cantidad)
        {
            //si no hay mas producto se elimina del deposito
            if ((vendido.cantidad - cantidad) <= 0)
            {
                QuitarCosteados(vendido);
                Deposito.Remove(vendido);
            }
            else
            {
                string name = vendido.Nombre;
                int article = vendido.cod_articulo;
                Proveedor provider = vendido.Proveedor;
                int quant = vendido.cantidad - cantidad;
                double cost = vendido.prec;
                DateTime fecha = vendido.date;
                Producto_comp prod = new Producto_comp(name, article, provider, quant, cost, fecha);
                VendidoCosteado(prod , cantidad);
                Deposito.Add(prod);
                Deposito.Remove(vendido);
            }
        }
        //PRODUCTO VENDIDO 
        public void VendidoCosteado(Producto_comp vendido , int cantidad)
        {
            Costeados costeado=null;
            ListaInvertida = CalculoCosto;
            ListaInvertida.Reverse();
            List<Costeados> vend = new List<Costeados>();
            foreach (var C in CalculoCosto)
            {
                if (C.Nombre == vendido.Nombre)
                {
                    costeado = new Costeados(vendido.Nombre, vendido.prec, vendido.cantidad , vendido.date, vendido.Proveedor);
                    vend.Add(C);
                }
            }
            foreach(var L in vend)
            {
                CalculoCosto.Remove(L);
            }
                       
            CalculoCosto.Add(costeado);
           
        } 
        //PRODUCTO VENDIDO SIN STOCK
        public void QuitarCosteados(Producto_comp SinStock)
        {
            ListaInvertida = CalculoCosto;
            ListaInvertida.Reverse();
            Costeados vend = null;
            foreach (var C in ListaInvertida)
            {
                if (C.Nombre == SinStock.Nombre)
                {
                    vend = C; 
                }
            }
            CalculoCosto.Remove(vend);
        }

        //CREAR NUEVO PRODUCTO
        public Producto_comp NuevoProducto (string nom , int cod_art , Proveedor prov , int cantidad , double unitario , DateTime fecha)   
        {
            Producto_comp n = new Producto_comp(nom, cod_art, prov, cantidad, unitario, fecha);
            return n;

        }
        //AGREGA UN PRODUCTO EN EL DEPOSITO
        public void agregarProducto(Producto_comp agregar)
        {
            Costeados n = new Costeados(agregar.Nombre, agregar.prec, agregar.cantidad, agregar.date , agregar.Proveedor);
            CalculoCosto.Add(n);
            Deposito.Add(agregar);
          
        }
        //AGREGAR UN PRODUCTO EN DEPOSITO , CAMBIAR EN COSTO
        //SOBRECARGA DE METODOS
        public void agregarProducto(Producto_comp agregar , int cantidad)
        {
            Costeados n = new Costeados(agregar.Nombre, agregar.prec, cantidad  , agregar.date, agregar.Proveedor);
            
            CalculoCosto.Add(n);
            Deposito.Add(agregar);

        }
        //AGREGA UN NUEVO CONJUNTO USUARIO/PASS
        public void agregarUser_Pass(string usuario , string password)
        {
            Ingresos.Add(usuario, password);

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

    

