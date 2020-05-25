using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    interface IPagableMensual
    {
        decimal Monto(int mes);
        string Descripcion();
       
        /*     Son conjuntos de prototipos , estos me permiten " obligar" a 
               las clases a implemetar los metodos (Monto , Descripcion() )      */
    }
}
