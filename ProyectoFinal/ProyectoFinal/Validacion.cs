using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    //ESTA CLASE VALIDA LAS ENTRADAS EN EL FORMULARIO PARA EVITAR EXCEPCIONES POR ERROR DE PARSEO E INGRESOS INCORRECTOS
    class Validacion
    {
        public static void NumeroDecimal(KeyPressEventArgs D)
        {
            if (char.IsDigit(D.KeyChar)) { D.Handled = false; }
            else if (char.IsSeparator(D.KeyChar)) { D.Handled = false; }
                else if (char.IsControl(D.KeyChar)) { D.Handled = false; }
                     else if (D.KeyChar.ToString().Equals(",")){ D.Handled = false; }
            else { D.Handled = true; };   
        }
        public static void NumeroEnteros(KeyPressEventArgs D)
        {
            if (char.IsDigit(D.KeyChar)) { D.Handled = false; }
            else if (char.IsSeparator(D.KeyChar)) { D.Handled = false; }
            else if (char.IsControl(D.KeyChar)) { D.Handled = false; }
            
            else { D.Handled = true; };
        }


























    }
}
