using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LibroCalificaciones
{
    private string nombreCurso;  //nombre del curso para este LibroCalificaciones

    //el constructor inizializa nombreCurso con el objeto string suministrado como argumento
    public LibroCalificaciones(string nombre)
    {
        nombreCurso = nombre; //inicializa nombreCurso usando la propiedad    
    } //fin del constructor

    //propiedqad para obtener(get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }//fin del get
        set
        {
            nombreCurso = value;
        }//fin del set
    }//fin de la propiedad NombreCurso
     // muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
    public void MostrarMensaje()
    {
        //usa la propiedad nombre curso para obtener el 
        // nombre del curso que representa este LibroCalificaciones
        Console.WriteLine("Bienvenido al libro de calificaciones para \n{0}!", NombreCurso);
    }//fin dek metodo mostrar mensaje 
}//fin de la clase LibroCalificaciones
