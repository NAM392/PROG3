using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_facturas
{
    class Factura
    {
        private int NF;
        private  List<Item> it ;

        public Factura(int nroF , List<Item> item)
        {
            NF = nroF;
            it = item;
        }

        public List<Item> Items
        {
            get { return it; }

        }
        public int n_factura
        {
            get { return NF; }
        }


    }
}
