using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIN
{
    class MaxContain
    {
        private string palabra;
        private double cont = 0;

        public MaxContain (string x)
        {
            x = palabra;

        }

        public int Contador
        {
            get
            {
                foreach (char Letra in palabra)
                {
                    cont++;
                }

            }
            set
            {
                return cont;
            }



        }













    }
}
