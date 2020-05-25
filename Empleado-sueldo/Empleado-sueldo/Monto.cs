using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Monto
    {
        const decimal cambio = 63.50m;
        private decimal pesos;
        private decimal dolares;

        /*Ejemplos de metodos static junto con otros que no lo son*/

        public Monto (decimal pesos)
        {
            this.pesos = pesos;
        }

        public decimal Pesos
        {
            get { return pesos; }
            set { pesos = value; }
        }

        public decimal Dolares
        {
            get { return PesoADolar(pesos); }
        }

        public static decimal PesoADolar(decimal p)
        {
            return p / cambio;
        }

        public static decimal DolarAPeso(decimal d)
        {
            return d * cambio;
        }
        

    }
}
