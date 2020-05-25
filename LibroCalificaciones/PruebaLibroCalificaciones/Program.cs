using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLibroCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones prueba1 = new LibroCalificaciones("Probando que aparecera");
            LibroCalificaciones prueba2 = new LibroCalificaciones("VeremosVeremos");

            Console.WriteLine("lo que aprece en pruebita1 {0} ", prueba1.NombreCurso);
            Console.WriteLine("lo que aprece en pruebita222 {0} ", prueba2.NombreCurso);

            Console.ReadKey();
        }
    }
}
