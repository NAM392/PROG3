using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class PlazoFijo
    {
        
        private int mes;
        private decimal monto;

        public decimal amount
        {
            get
            {
                return monto;
            }

        }


        public int month
        {
            get
            {
                return mes;
            }

        }

        public PlazoFijo( int m , decimal mon)
        {
            monto = mon;
            mes = m;


        }


    }
}
