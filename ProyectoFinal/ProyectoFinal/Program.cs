/*
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
        public static Sistema_Rep getSistema()
        {
            return s;
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            s = new Sistema_Rep();
            
            //usuario y contraseña
            Dictionary<string, string> Ingresos = Program.getSistema().getIngresos();
            Ingresos.Add("nicolas", "minnicelli");
            Ingresos.Add("mauro", "gullino");
            Ingresos.Add("Mauro", "Gullino");
            //proveedores iniciales
            Proveedor pr = new Proveedor("GOMEZ srl ", "lala 12", 111);
            s.agregarProveedor(pr);
            Proveedor pl = new Proveedor("KÖS sas ", "mstra mñz 13", 111);
            s.agregarProveedor(pl);
            //fecha
            DateTime dt = new DateTime( 2019 , 6 , 20) ;
            //productos iniciales
            Producto_comp prod = new Producto_comp("Tornillos", 123, pr, 323, 1.4, dt);
            Producto_comp prod2 = new Producto_comp("Arandelas", 256, pl, 157, 2.3, dt);
            Producto_comp prod3 = new Producto_comp("Media Omega", 620, pl, 621, 0.75, dt);
            s.agregarProducto(prod);
            s.agregarProducto(prod2);
            s.agregarProducto(prod3);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());



            // -----------------------------------
            // descomentar siguiente bloque para la primera ejecución (creación del archivo por 1ra vez)

            //el método agregarFactura de Sistema hace un Add en la List<Factura> que vive en Sistema
            //por eso, cuando serialice Sistema se van a terminar serializando todo los datos.
            

                        Stream flujo2 = File.Create("datos.bin");
                        BinaryFormatter serializer = new BinaryFormatter();
                        serializer.Serialize(flujo2, s);
                        flujo2.Close();
                        MessageBox.Show("archivo creado. volver a comentar el bloque en el main.");
                        return; //termina el Main

            /* 

            // -----------------------------------


            //este bloque es la deserialización, donde la clase Sistema que quedó guardada
            // en el archivo se vuelve a poner en memoria.

            try
            {
                
               Stream flujo = File.OpenRead("datos.bin");
               BinaryFormatter deserializer = new BinaryFormatter();
               s = (Sistema_Rep)deserializer.Deserialize(flujo);
               flujo.Close();
           }
           catch (Exception e)
           {
               //si falla lo anterior es porque no está creado el archivo, no se puede continuar.
               MessageBox.Show("descomentar bloque del main para crear el archivo por primera vez. terminando programa.");
               return; //termina el Main
           }
            

            Application.ApplicationExit += new System.EventHandler(SerializarAlSalir); //ApplicationExit = evento que se dispara al cerrar la app


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

*/





using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoFinal
{

    
    static class Program
    {
        private static Sistema_Rep s;
        public static Sistema_Rep getSistema()
        {
            return s;
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // -----------------------------------
            // descomentar siguiente bloque para la primera ejecución (creación del archivo por 1ra vez)

            /*//atras de esto se descomenta

            s = new Sistema_Rep();

            //proveedores iniciales
            Proveedor pr = new Proveedor("GOMEZ srl ", "lala 12", 111);
            Proveedor pl = new Proveedor("KÖS sas ", "mstra mñz 13", 111);
            //fecha
            DateTime dt = new DateTime( 2019 , 4 , 20) ;
            DateTime dt2 = new DateTime( 2020 , 5 , 3) ;
            DateTime dt3 = new DateTime( 2018 , 8 , 31) ;
            //productos iniciales
            Producto_comp prod = new Producto_comp("Tornillos", 123, pr, 323, 1.4, dt);
            Producto_comp prod2 = new Producto_comp("Arandelas", 256, pl, 157, 2.3, dt2);
            Producto_comp prod3 = new Producto_comp("Media Omega", 620, pl, 111, 0.75, dt3);
            s.agregarProducto(prod);
            s.agregarProducto(prod2);
            s.agregarProducto(prod3);
            s.agregarProveedor(pl);
            s.agregarProveedor(pr);
            //usuario y contraseña
            s.agregarUser_Pass("nicolas" , "minnicelli" );
            s.agregarUser_Pass("mauro" , "gullino" );
            s.agregarUser_Pass("Mauro" , "Gullino" );

               



                Stream flujo2 = File.Create("datos.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(flujo2, s);
                flujo2.Close();
                MessageBox.Show("archivo creado. volver a comentar el bloque en el main.");
                return; //termina el Main

            *///atras de esto se comenta

            // -----------------------------------





            // este bloque es la deserialización, donde la clase Sistema que quedó guardada
            // en el archivo se vuelve a poner en memoria.
            try
            {
               Stream flujo = File.OpenRead("datos.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                s = (Sistema_Rep)deserializer.Deserialize(flujo);
                flujo.Close();
            }
            catch (Exception e)
            {
                //si falla lo anterior es porque no está creado el archivo, no se puede continuar.
                MessageBox.Show("descomentar bloque del main para crear el archivo por primera vez. terminando programa.");
                return; //termina el Main
            }


            Application.ApplicationExit += new System.EventHandler(SerializarAlSalir); //ApplicationExit = evento que se dispara al cerrar la app

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
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
