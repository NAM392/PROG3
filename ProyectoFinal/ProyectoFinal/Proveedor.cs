using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Proveedor
    {

        private string name;
        private string direction;
        private int telephone;
        
        public Proveedor(string nombre, string direccion, int telefono)
        {
            name = nombre;
            direction = direccion;
            telephone = telefono;
        }

        public string Nombre
        {
            get { return name; }
        }
        public string direc
        {
            get { return direction; }
        }
        public int tel
        {
            get { return telephone; }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
