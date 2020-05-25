using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_facturas
{
    class Sistema
    {
        static protected Factura[] Facturas { get; set; }
        static public void Inicializar()
        {
            
            Console.WriteLine("ingrese cuantas facturas desea crear ");
            int J = int.Parse(Console.ReadLine());

            //creo array de facturas
            Factura[] ff = new Factura[J];

            for (int i = 0; i < J; i++) {
                //ingreso numero de factura
                Console.WriteLine("\n\n\tingrese numero de la nueva factura : ");
                int N_Factura = int.Parse(Console.ReadLine());


                //creo item

                List<Item> item = new List<Item>();

                Console.WriteLine("ingrese cantidad de items : ");
                int I = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t***CARGANDO ITEMS***\n\n");
                for (int k = 0; k < I; k++)
                {
                    Console.WriteLine("\n\nCARGANDO ITEM {0}", k+1);

                    //cargo items
                    Console.WriteLine("ingrese codigo del producto : ");
                    string codigo = Console.ReadLine();

                    Console.WriteLine("ingrese nombre proveedor : ");
                    string proveedor = Console.ReadLine();

                    var producto = new Dictionary<string, string>();
                    producto.Add(codigo, proveedor);


                    Console.WriteLine("ingrese cantidad del producto : ");
                    int cantidad = int.Parse(Console.ReadLine());


                    Console.WriteLine("ingrese precio del producto : ");
                    double precio = double.Parse(Console.ReadLine());

                    double total = 0;
                    total = (precio * cantidad) + total;

                    var IT = new Item(producto, cantidad, precio, total);
                    item.Add(IT);

                }

                //creo Factura

                ff[i] = new Factura(N_Factura, item);
            }
            //copio todas las facturas creadas dentro de la variable protected Facturas ,
            //la cual se va a poder ver desde todas las clases heredadas
            Facturas = ff; 
        }
      
        //GET FACTURA

         static public Factura getFactura(int numero) 
         {
            //recorro las facturas que tengo guardadas en la variable protected Facturas
           foreach(var F in Facturas)
            {
                //si el numero de factura es igual al preguntado , retorno esa factura
                if(F.n_factura == numero)
                {
                    return F;
                }

                /******************
                //EXCEPCION
                if(F.n_factura != 238)
                {
                    throw new Factura_Inexistente();
                }
                *****************/
            }
           
            return null;

         }

                  
         static public List<Factura> FacturasConProductoYCantidadMayorA(string codproducto, int cantidad)
         {
            List<Factura> facturas_mayor = new List<Factura>(); //creo la variable que va a ser devuelta

                //recorro las facturas dentro del array
                foreach(var fac in Facturas)
                {
                    //
                    foreach( var KV in fac.Items)
                    {

                        foreach( KeyValuePair<string,string> cod in KV.Product)
                        {
                               //si la key y el value son iguales a los requeridos
                               if (cod.Key == codproducto && KV.quantity >= cantidad)
                               {
                                 //agrego facturas adentro de list
                                 facturas_mayor.Add(fac);
                               }

                        }


                    }

                }
            
            return facturas_mayor;  

         }

       static public List<Factura> FacturasporProveedoryStock(string proveedor , int stock)
        {
            List<Factura> proveedor_stock = new List<Factura>(); //creo la variable que va a ser devuelta

            //recorro las facturas dentro del array
            foreach (var fac in Facturas)
            {
                //
                foreach (var KV in fac.Items)
                {

                    foreach (KeyValuePair<string, string> cod in KV.Product)
                    {
                        //si la key y el value son iguales a los requeridos
                        if (cod.Value == proveedor && KV.quantity < stock)
                        {
                            //agrego facturas adentro de list
                            proveedor_stock.Add(fac);
                        }

                    }


                }

            }

            return proveedor_stock;

        }
       
        static public List<Factura> MontoMayorA(double monto)
        {
            List<Factura> montoMayor = new List<Factura>(); //creo la variable que va a ser devuelta

            //recorro las facturas dentro del array
            foreach (var fac in Facturas)
            {
                //recorro los items
                foreach (var KV in fac.Items)
                {

                    //si la key y el value son iguales a los requeridos
                    if (KV.total >= monto)
                    {
                        montoMayor.Add(fac);
                    }
        
                }

            }

            return montoMayor;

        }












    }
    class Factura_Inexistente : Exception
    {


    }

}
