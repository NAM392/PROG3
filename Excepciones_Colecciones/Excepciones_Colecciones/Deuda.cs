using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Colecciones
{
    class Deuda
    {
        public double ObtenerDeudaMensual(ushort mes)
        {
            if (mes < 1 || mes > 12)
            {
                throw new mesInexistente();
            }
            return 333;
        }
    }

    /* se declara esta clase de excepciones fuera de la clase*/
    class mesInexistente : Exception
    {


    }




} 






