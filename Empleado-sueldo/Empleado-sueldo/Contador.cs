using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Contador
    {
        private static int sucesos = 0;

        public int VerContador()
        {
            return sucesos;
        }

        public static Contador operator ++ (Contador c)
        {
            sucesos++;
            return c;

        }






    }
}
