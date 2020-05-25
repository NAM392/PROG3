using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Factura : IPagableMensual
    {
        int mes;
        decimal monto;
        string proveedor;

        public Factura ( string po , int me , decimal mo)
        {
            proveedor = po;
            mes = me;
            monto = mo;

        }

        public decimal Monto(int m)
        {
            if (m == mes) return monto;
            else return 0;
        }
        public string Descripcion()
        {
            return proveedor;
        }


        /*    SOBRECARGA DE OPERADORES  */
        public static bool operator < (Factura a , Factura b)
        {
            if (a.monto < b.monto) return true;
            else return false;

        }

        public static bool operator >(Factura a, Factura b)
        {
            if (a.monto > b.monto) return true;
            else return false;

        }

        public static Factura operator +(Factura a, Factura b)
        {
            // if  a.mes != b.mes  tenemos problemas  

            return new Factura(a.proveedor + "+" + b.proveedor, a.mes, a.monto + b.monto);

        }



    }



}
