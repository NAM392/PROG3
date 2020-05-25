using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo 
{
    class EmpleadoPorHoras : EmpleadoBase , IPagableMensual
    {
        private decimal valorHora;
        private int horasTrabajadas;
        //constructor y llamada a clase base

        public EmpleadoPorHoras(string n , decimal vh , int ht) : base(n,0)
        {
            valorHora = vh;
            horasTrabajadas = ht;

        }

        /*la diferencia entre la clase padre Empleado y la clase hija EmpleadoPorHora es CalcularSueldo
         con este fin se utilizan la herencia de clase , 
         es poder modificar o agregar algunos elementos especificos de la clase Empleado
             */
        public override decimal calcularSueldo(int mes)
        {
            return valorHora*horasTrabajadas;

        }

        public decimal Monto(int mes)
        {
            return calcularSueldo(mes);
        }
        public string Descripcion()
        {
            return Nombre;
        }




    }
}
