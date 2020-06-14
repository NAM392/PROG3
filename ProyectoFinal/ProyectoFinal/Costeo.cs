using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Costeo
    {
        static public string FIFO(Producto_comp elegido)
        {

            List<Producto_comp> PG = //Repository();

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

            List<Producto_comp> PG = //Repository();

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

            List<Producto_comp> PG = //Repository();
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
