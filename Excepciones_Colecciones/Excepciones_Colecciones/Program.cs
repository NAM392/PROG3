using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Colecciones
{
    class Program
    {
        static void Main(string[] args)

        {

            //poniendo el nombre del metodo (yr :) y asignandolo , no importa la posicion

            naamed ns = new naamed(yr: 141, sl: 3.14, nom: "pepe");



            //prueba("pepe" , 20 , 300.40)

            Console.WriteLine(ns.year);
            Console.WriteLine(ns.amount);
            Console.WriteLine(ns.name);


            int valor = 10;
            string str1 = "hola", str2 = "chau";

            Console.WriteLine(valor);

            //esta funcion cambia el valor de esta variable por referencia
            //cambia el pasaje dentro de la funcion y sigue distinta fuera de ella
            //se usa para "ahorrar " memoria , utilizando una misma variable
            reference(ref valor, ref str1, ref str2);

            Console.WriteLine(valor);

            _out(out valor, out str1, out str2);



            string origen = "997";
            int num;

            if (Int32.TryParse(origen, out num))
            {
                Console.WriteLine($@"Convertido '{origen}' to '{num}'");
            }
            else
            {
                Console.WriteLine($@"No se pudo convertir '{origen}'");
            }



            Deuda d1 = new Deuda();


            try
            {
                /*aca pongo el codigo (no importa la cantidad de lineas) que preveo puede fallar */
                Console.WriteLine(d1.ObtenerDeudaMensual(/*si puesiera 999 probaria el error*/3));
            }

            /*luego de salir del TRY (pasa esto porque hubo un error) entra al catch que corresponda 
             * con la clase que tiene dentro el metodo que llamamos y obligatoriamente Exception   */

            catch (mesInexistente obj1)
            {
                Console.WriteLine("el mes indicado no existe");
            };

            /*  
             *  REVISAR PORQUE DA ERROR AL ENTRAR ACA
             catch(Exception obj2) { 
                            Console.WriteLine("ocurrio un error deconocido");
            }
            */

            //----------------------------------------------------------------------------------


            // utilizando <>  ; < aca va cualquier cosa , se usa T > no restrinjo la funcion a un solo tipo de variable

            //  TYPE PARAMETER
            //Metodo generico


            int x = 5, y = 10;
            Intercambiador<int>(ref x, ref y);


            //Ejemplo de Clase Type Parameter 

            Pilita<int> pila = new Pilita<int>();
            pila.poner(4);
            pila.poner(5);

            Console.WriteLine(pila.sacar());
            Console.WriteLine(pila.sacar());


            /* List<T> es un vector dinamico 
             * este array puede ser de cualquier tipo*/

            //creo la Lista alumnos

            /*si o si tengo que poner var (variable)*/
            var alumnos = new List<string>();

            //agrego un alumno dentro de la lista alumnos
            alumnos.Add("pepe");
            alumnos.Add("juan");
            alumnos.Add("Maria");
            alumnos.Remove("juan");
            alumnos.Insert(1, "segundo");
            alumnos.Remove("chaucha");


            for(int i=0; i< alumnos.Count; i++)
            {
                Console.WriteLine(alumnos[i]);
            }

            Console.WriteLine(alumnos.Contains("carlitos"));
            Console.WriteLine(alumnos.IndexOf("segundo"));


            foreach (var al in alumnos)
            {
                Console.WriteLine(al);
            }


            Console.WriteLine("\n\n");

            List<int> numeros = new List<int>();

            for(int i=0; i<=20; i++)
            {
                numeros.Add(i);
            }
            /* Cuando remuevo elementos nomenclados , lo unico que voy a hacer es borrar su contenido 
               se va a crear automaticamente otro List conteniendo estos */
            for(int i=0; i< numeros.Count; i++)
            {
                if(numeros[i] % 2 == 1)
                {
                    numeros.RemoveAt(i);
                }
            }

            foreach(var number in numeros)
            {
                Console.WriteLine(number);
            }







            Console.ReadKey();




        }
        static void reference(ref int i, ref string str1, ref string str2)
        {
            i = 44;
            str1 = "retorname";

        }
        static void _out(out int i, out string str1, out string str2)
        {
            i = 9292;
            str1 = "salida";
            str2 = null;

            /*este pasaje es igual que el de referencia , pero todas las variables 
              tienen que ser asignadas sino tiene un error de compilacion 
              (probar comentanto algo // )*/

        }

        static void Intercambiador<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;

        }
    }
}