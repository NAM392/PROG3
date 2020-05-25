using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Empleado e1 = new Empleado("pepe", 15000);
            Console.WriteLine(e1.Nombre); //pepe
            Console.WriteLine(e1.calcularSueldo(3)); //15000
            EmpleadoPorHoras eh = new EmpleadoPorHoras("jose", 150, 36);

            Console.WriteLine(eh.Nombre); //jose
            Console.WriteLine(eh.calcularSueldo(8));

            /* EmpleadoPorHoras.calcularSueldo me va a dar 0 porque asi esta declarado en su constructor
             y es el parametro que le pasamos a Empleado , si por el contrario llamamos con el mismo nombre 
             calcularSueldo pero ahora dentro de EmpleadoPorHoras nos va a dar el resultado de este
             en este caso va a ser 5400
             */

            Console.WriteLine(eh is Empleado); //true

            /*
            Empleado e2 = new EmpleadoPorHoras("kike", 200, 24);
            Console.WriteLine(e2.calcularSueldo(4));

            La referencia de la variable e2 (Empleado) indica cual de los miembros se van a utilizar
              en este caso va a ser el resultado 0 porque asi esta indicado en calcularSueldo de la clase Empleado 
             EL OBJETO ES EmpleadoPorHoras PERO LLAMA AL METODO calcularSueldo DE Empleado 
             */

            /* Para que podamos usar el metodo calcularSueldo de la clase EmpleadoPorHoras cuando nosotros 
             referenciamos Empleado (Empleado e2) debemos agregar la palabra reservada virtual en el metodo de la clase padre (Empleado.calcularSueldo)
             y agregar la palabra reservada override en el metodo la clase hija (EmpleadoPorHoras.calcularSueldo)

             */

            Empleado[] emps = new Empleado[5];
            emps[0] = new Empleado("tito", 15000);
            emps[1] = new Empleado("juan", 18000);
            emps[2] = new Empleado("maria", 20000);

            //emps[3] = new EmpleadoPorHoras("Roberto", 150 , 10);
            // emps[4] = new EmpleadoPorHoras("Ana", 300 , 20);


            // foreach (Empleado e in emps)
            //{
            //  Console.WriteLine(e.Nombre + "  " + e.calcularSueldo(1));
            //}


            //Este array de IpagableMensual es posible porque todas esas clases implementan esta interfaz

            IPagableMensual[] deudas = new IPagableMensual[5];

            deudas[0] = new Empleado("juan", 15000);
            deudas[1] = new Empleado("terry", 20000);
            deudas[2] = new EmpleadoPorHoras("pipo", 150, 10);
            deudas[3] = new EmpleadoPorHoras("chelo", 300, 20);
            deudas[4] = new Factura("Ferreteria cacho", 1, 890.50m);

            /*            

             foreach (IPagableMensual i in deudas)
             {
                 Console.WriteLine(i.Descripcion() + "  " + i.Monto(2));
             }


             */
            //utilixando el metodo ImprimirPagos de la clase Tesoreria reemplazo el foreach anterior
            Tesoreria t = new Tesoreria();
            //Ejemplo de sobrecarga de METODOS

            // t.ImprimirPagos(deudas, 1);
            t.ImprimirPagos(deudas);

            //Ejemplo de sobrecarga de OPERADORES

            Factura f1 = new Factura("roberto s.a", 2, 890.5m);
            Factura f2 = new Factura("estevan oriol nts", 3, 120.5m);
            Factura f3 = f1 + f2;

            Console.WriteLine(f1 < f2);
            Console.WriteLine(f3);


            Monto m = new Monto(300);
            Console.WriteLine(m.Pesos);
            Console.WriteLine(Math.Round(m.Dolares , 2));
            Console.WriteLine(Monto.DolarAPeso(100));

            Contador c1 = new Contador();
            Contador c2 = new Contador();


            /*La variable sucesos que vive adentro de la clase Contador es del tipo static ,
             * por ende no importe las clases que instancie voy a tener siempre el mismo resultado */
            c1++;
            c1++;
            c2++;

            Console.WriteLine(c1.VerContador());
            Console.WriteLine(c2.VerContador());
            c1++;
            Console.WriteLine(c1.VerContador());

            Venta v1 = new Venta("nicolas", 3, 2500);

            Console.WriteLine(v1.name  + " " + v1.month + " " + " " + v1.amount);

            PlazoFijo pz1 = new PlazoFijo(4, 12300);

            Console.WriteLine(pz1.month + " " + pz1.amount);


            aCobrar[] AC = new aCobrar[6];

            AC[0] = new aCobrar(1, 15000);
            AC[1] = new aCobrar(2, 2100);
            AC[2] = new aCobrar(1, 75000);
            AC[3] = new aCobrar(3, 22000);
            AC[4] = new aCobrar(9, 150);
            AC[5] = new aCobrar(4, 4500);


            aPagar[] AP = new aPagar[4];

            AP[0] = new aPagar(9, 1000000);
            AP[1] = new aPagar(7, 5720);
            AP[2] = new aPagar(1, 7000);
            AP[3] = new aPagar(3, 22000);


            Tesoreria.EstadoContable(AC, AP);



            //  Funcion para comparar objetos ( en caso que se quiera ingresar 
            //  un solo array en EstadoContable)

            if(AP.GetType() != AC.GetType())
            { Console.WriteLine("Objetos distintos "); }





            Console.ReadKey();


        }

    }
}
