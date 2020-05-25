using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{

    //NO se puede hacer una instancia de una clase abstracta
    // EmpleadoBase eb = new EmpleadoBase() ;
    abstract class EmpleadoBase : IPagableMensual
    {
        protected string nombre;  //los tipos de accesibilidad protected son accesibles en las clases derivadas
        protected decimal sueldo;      // no asi desde fuera de la clase
        public string Nombre
        {
            get { return nombre; }

        }

        public EmpleadoBase(string n , decimal s)
        {
            nombre = n;
            sueldo = s;
            //al ser este un metodo abstracto (no tiene ninguna implementacion para este metodo)
            //toda la clase se tiene que definir como abstracta
            
        }
        public abstract decimal calcularSueldo(int mes);
        public decimal Monto(int mes)
        {
            return calcularSueldo(mes);
        }
        public string Descripcion()
        {
            return nombre;
        }

        /* la finalidad de utilizar una metodo y una clase abstracta es pensar en el futuro de la implementacion del
          proyecto , en este ejemplo seria nuevos tipos de empleados con nuevas formas de calcular su sueldo , etc*/
    }
}
