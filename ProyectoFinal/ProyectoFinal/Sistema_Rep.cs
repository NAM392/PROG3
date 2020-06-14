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

        private static List<Producto_comp> Deposito;
        private static List<Producto_comp> PG;



        public Sistema_Rep ()
        {
            Deposito = new List<Producto_comp>();
        }
        
        public  List<Producto_comp>  getSistema()
        {
            return Deposito;
        }
        
        static public void agregarProducto(Producto_comp agregar)
        {
            Deposito.Add(agregar);
        }

        static public string FIFO(Producto_comp elegido)
        {
             PG = Deposito;

            foreach (var p in PG)
            {
                if (p.Nombre == elegido.Nombre)
                {
                    return (p.prec).ToString();
                }
            }
            return "0";
        }
        static public string LIFO(Producto_comp elegido)
        {
            PG = Deposito;

            PG.Reverse();

            foreach (var p in PG)
            {
                if (p.Nombre == elegido.Nombre)
                {
                    return (p.prec).ToString();
                }
            }

            return "0";
        }
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












































        /*
      static public void Repository()
      {
          Deposito = new List<Producto_comp>();

          Producto_comp p1 = new Producto_comp("Tornillos", 134, 717, 14, 23.2);
          Producto_comp p2 = new Producto_comp("Arandelas", 120, 717, 8, 13.7);
          Producto_comp p3 = new Producto_comp("Media Omega", 237, 156, 33, 43.5);
          Producto_comp p4 = new Producto_comp("Tornillos", 134, 827, 7, 28.9);

          Deposito.Add(p1);
          Deposito.Add(p2);
          Deposito.Add(p3);
          Deposito.Add(p4);







      }



      static public List<Producto_comp> GetProductos()
      {
          //Repository(); 
          return Deposito;

      }
      static public void SetProductos(Producto_comp prod)
      {
          // List<Producto_comp> PG = new List<Producto_comp>();
          //PG.Add(prod);

          Repository();
          Deposito.Add(prod);




          // Deposito = PG;
          //Deposito.Add(PG);


      }

      */


















    }
}

    

