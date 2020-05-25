using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Colecciones
{
    class naamed
    {

        private string nombre;
        private double sueldo;
        private int Edad;

        public naamed(double sl, string nom , int yr)
        {
            sueldo = sl;
            nombre = nom;
            Edad = yr;


        }



        public double amount
        {
            get { return sueldo; }
            set { sueldo = value; }
           
        }

        public string name
        {
            get { return nombre; }
            set { nombre = value; }
           
        }

        public int year
        {
            get { return Edad; }
            set { Edad = value; }
            

        }

    















    }
}
