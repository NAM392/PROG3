﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class aPagar
    {

        private int Mes;
        private decimal Monto;


        public int month
        {
            get
            {
                return Mes;
            }

        }

        public decimal amount
        {
            get
            {
                return Monto;
            }

        }

        public aPagar(int m, decimal mon)
        {
            Monto = mon;
            Mes = m;


        }





























    }
}
