using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    [Serializable]
    class Proveedor
    {

        private string name;
        private string direction;
        private long telephone;
        
        public Proveedor(string nombre, string direccion, long telefono)
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
        public long tel
        {
            get { return telephone; }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
