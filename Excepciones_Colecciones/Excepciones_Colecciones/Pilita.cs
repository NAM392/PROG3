using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Colecciones
{
    class Pilita <tt>
    {
        private tt[] datos;
        private int tope = 0;

        public Pilita()
        {
            datos = new tt[10];
            //instancio un array en el constructor
        }
        public void poner(tt x)
        {
            datos[tope] = x;
            tope++;
        }
        public tt sacar()
        {
            tope--;
            return datos[tope];
        }












    }
}
