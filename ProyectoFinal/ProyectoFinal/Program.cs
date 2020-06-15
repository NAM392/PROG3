using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new STC());
            /*
            Producto_comp p1 = new Producto_comp("Tornillos", 134, 717, 14, 23.2);
            Producto_comp p2 = new Producto_comp("Arandelas", 120, 717, 8, 13.7);
            Producto_comp p3 = new Producto_comp("Media Omega", 237, 156, 33, 43.5);
            Producto_comp p4 = new Producto_comp("Tornillos", 134, 827, 7, 28.9);

            Deposito.Add(p1);
            Deposito.Add(p2);
            Deposito.Add(p3);
            Deposito.Add(p4);

            */



















        }
    }
}
