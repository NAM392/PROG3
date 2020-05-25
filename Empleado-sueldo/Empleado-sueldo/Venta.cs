using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Venta
    {
        private string nom_cliente;
        private int mes;
        private decimal monto;

        public string name
        {
            get
            {
                return nom_cliente;
            }
        }

        public int month
        {
            get
            {
                return mes;
            }

        }

        public decimal amount
        {
            get
            {
                return monto;
            }
        }



        public Venta(string nc, int m, decimal mon)
        {
            nom_cliente = nc;
            monto = mon;
            mes = m;
             
        }



    }
}
