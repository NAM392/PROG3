using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Ccolecciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* las colas queue son del tipo FIFO y 
                 se implementan con un array */
            Queue<string> numeros = new Queue<string>();
            numeros.Enqueue("uno");
            numeros.Enqueue("dos");
            numeros.Enqueue("tres");

            while(numeros.Count > 0)
            {
                Console.WriteLine(numeros.Dequeue());
            }

           // se pueden enumerar sin alterarlo
           foreach(string n in numeros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(numeros.Contains("dos"));

            //mira el proximo , sin desencolarlo
            //Console.WriteLine(numeros.Peek());

            numeros.Clear();

            LinkedList<string> frase = new LinkedList<string>();

            frase.AddFirst("Mundo");
            frase.AddFirst("Hola");
            frase.AddLast("Cruel");
            frase.RemoveFirst();
            frase.AddFirst("adios");


            foreach(var fr in frase)
            {
                Console.WriteLine(fr + " "); 
            }

            //las LinkedList estan compuestas por LinkedListNode

            /*  Esta seria una funcion de busqueda
            busca dentro de la lista enlazada , un nodo de lista enlazada
            que contiene "Mundo"  y devuelve la referencia (posicion en memoria) donde se encuentra 
             en este caso se asigna en busq  */

            LinkedListNode<string> busq = frase.Find("Mundo");

            //con AddAfter le paso una referencia y puedo agregar algo antes             
            frase.AddAfter(busq, "tan");
            /*     VER DOCUMENTACION PARA CONOCER LAS FUNCIONES DE LISTAS ENLAZADAS   */

            Console.WriteLine(busq.Next);//la referencia al nodo siguiente 
            Console.WriteLine(busq.Next.Value); // valor almacenado al numero siguiente de busq
            Console.WriteLine(frase.Count); // cantidad de nodos dentro de la LinkedList frase



            /****  DICCIONARIOS *****/
            Console.WriteLine("\n\n\t  ");

            var clientes = new Dictionary<int, string>();
            clientes.Add(32, "pepe");
            clientes.Add(2, "juancito");
            clientes.Add(4356, "maria");
            clientes.Add(111, "leopoldo");
            clientes.Remove(2);
            clientes[32] = "pepe II";


            // Console.WriteLine(clientes[55]);
            // dentro del diccionario clientes no esta la referencia o clave (Key) con numero 55
            Console.WriteLine(clientes[32]);



            //KeyValuePair me devuelve clave/valor del diccionario
            foreach(KeyValuePair<int , string> cv in clientes)
            {
                Console.WriteLine(cv.Key + ":" + cv.Value);

            }

            // Console.WriteLine(clientes[555]);
            Console.WriteLine(clientes.ContainsKey(555)); /* devuelve un boolean */


            /* con TryGetValue le paso una clave , me devuelve el contenido de esa clave 
               a continuacion yo lo paso por referencia a la variable "val" para ser mostrada */

            if(clientes.TryGetValue(32 , out string val))  
            {
                Console.WriteLine("valor es : {0}", val);
            }
            else
            {
                Console.WriteLine("Clave no encontrada");
            }

            /*  esta funcion nos devuelve el codigo hash de cualquier objeto , en los diccionarios 
               la informacion se guarda en buckets numerados con los hash de los key value
                en este caso */
            clientes[32].GetHashCode();



            /*  Diccionario Ordenado  */
            Console.WriteLine("\n\n\t  ");

            var clientes_ordenados = new SortedDictionary<int, string>();
            clientes_ordenados.Add(32, "pepe");
            clientes_ordenados.Add(9999, "chiche");
            clientes_ordenados.Add(111, "lalo");
            
            foreach(var l in clientes_ordenados)
            {
                Console.WriteLine(l.Key + " " + l.Value);
            }






































            Console.ReadKey();

        }
    }
}
