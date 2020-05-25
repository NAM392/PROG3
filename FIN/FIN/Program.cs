using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIN
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string ingreso;
            string vocales = "AEIOUaeiou";
            string MAX_vocal = null;
            int cont = 0;
            int MAX_cont=0;

            Console.WriteLine("Ingrese palabras hasta apretar FIN");
            ingreso = Console.ReadLine();

            while (ingreso != "FIN") { 
                                       
                foreach (char Letra in ingreso)
                {
                    foreach(char vocal in vocales)
                     {
                        if(Letra == vocal)
                        {
                             cont++;
                         }
                     }
                }
                Console.WriteLine(cont);
                Console.WriteLine(MAX_cont);

                if (cont > MAX_cont)
                 {
                      MAX_cont = cont;
                      MAX_vocal = ingreso;
                      cont = 0;
                 }
                else
                {
                      cont = 0;
                }
                 ingreso = Console.ReadLine();
            }

            Console.WriteLine("La palabra con mayor cantidad de vocales es " + MAX_vocal);

            Console.ReadKey();

        }
    }
}
