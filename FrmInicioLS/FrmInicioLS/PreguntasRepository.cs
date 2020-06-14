using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmInicioLS
{
    class PreguntasRepository
    {
        static public Pregunta[] getPreguntas()
        {
            Pregunta[] ret = new Pregunta[3];

            ret[0] = new Pregunta("Cuanto mide el obelisco?", "68m", "45m", "83m");

            ret[1] = new Pregunta("Cual es la temperatura del sol ?", "5778K", "1900K", "9541K");

            ret[2] = new Pregunta("Que es una neurona?", "Una celula ", "Una mitocondria", "Un bioma");

            return ret;

        }

    }
}
