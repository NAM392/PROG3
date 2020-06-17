using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoFinal
{
    static class Program
    {
        private static Sistema_Rep s;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new STC());



            // -----------------------------------
            // descomentar siguiente bloque para la primera ejecución (creación del archivo por 1ra vez)

            /*
            
            s = new Sistema();

            Factura f = new Factura();
            f.agregarItem("Pan", 100);
            f.agregarItem("Queso", 300);
            s.agregarFactura(f);    //el método agregarFactura de Sistema hace un Add en la List<Factura> que vive en Sistema
                                    //por eso, cuando serialice Sistema se van a terminar serializando todo los datos.

            f = new Factura();
            f.agregarItem("Jamon", 450);
            f.agregarItem("Queso", 300);
            s.agregarFactura(f);
            */
            Stream flujo2 = File.Create("datos.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, s);
            flujo2.Close();
            MessageBox.Show("archivo creado. volver a comentar el bloque en el main.");
            return; //termina el Main



            // -----------------------------------



            /*

           // este bloque es la deserialización, donde la clase Sistema que quedó guardada
           // en el archivo se vuelve a poner en memoria.

           try
           {
               Stream flujo = File.OpenRead("datos.bin");
               BinaryFormatter deserializer = new BinaryFormatter();
               s = (Sistema_rep)deserializer.Deserialize(flujo);
               flujo.Close();
           }
           catch (Exception e)
           {
               //si falla lo anterior es porque no está creado el archivo, no se puede continuar.
               MessageBox.Show("descomentar bloque del main para crear el archivo por primera vez. terminando programa.");
               return; //termina el Main
           }


           Application.ApplicationExit += new System.EventHandler(SerializarAlSalir); //ApplicationExit = evento que se dispara al cerrar la app

           */
        }

        //este método va a ser llamado en el evento ApplicationExit
        //por lo tanto se ejecuta justo antes de que la aplicación termine, siempre
        public static void SerializarAlSalir(object sender, EventArgs e)
        {
            Stream flujo2 = File.Create("datos.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, s);  //notar que lo que se serializa es Sistema, y con ello recursivamente todo lo demás
            flujo2.Close();
            MessageBox.Show("objeto serializado ok. terminando programa.");
        }

    }
}
