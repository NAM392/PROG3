using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{

    // class Empleado : IPagableMensual
    //{ 


    class Empleado : EmpleadoBase, IPagableMensual
    {

        /*con esta herencia , Empleado se reduciria solamente a esta porcion de codigo , 
        porque todo lo demas lo hereda de EmpleadoBase
        tuve que comentar este codigo porque sino deja de funcionar el resto de las clases
        a excepcion de la interfaz IPagableMensual
        */

        public override decimal calcularSueldo(int mes)
        {
            return sueldo;

        }

        public Empleado(string n, decimal s) : base(n, s) { } 
           
    /*





        private string nombre;
       private decimal sueldo;

       public string Nombre
       {
           get
           {
               return nombre;
           }
       }

       public virtual decimal calcularSueldo (int mes)
       {
           return sueldo;
       }
       public Empleado(string n , decimal s)
       {
           nombre = n;
           sueldo = s;


       }

       public decimal Monto(int mes)
       {
           return calcularSueldo(mes);
       }
       public string Descripcion()
       {
           return Nombre;
       }


   
    */








    }
}
