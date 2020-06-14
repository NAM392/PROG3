using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmInicioLS
{
    class Pregunta
    {
        private string texto;
        private string correcta;
        private string incorrecta1;
        private string incorrecta2;

        public Pregunta(string texto , string correcta , string incorrecta1 , string incorrecta2)
        {
            this.texto = texto;
            this.correcta = correcta;
            this.incorrecta1 = incorrecta1;
            this.incorrecta2 = incorrecta2;

        }

        public string getTexto() { return texto; }

        public string[] getRespuestasPosibles()
        {
            string[] respuestas = new string[] { correcta, incorrecta1, incorrecta2 };


            Random azar = new Random();

            int n = respuestas.Length;
            while(n>1)//algoritmo Fisher-Yates
            {
                int indice = azar.Next(n--);
                string temp = respuestas[n];
                respuestas[n] = respuestas[indice];
                respuestas[indice] = temp;

            }
            return respuestas;

        }

        public bool esCorrecta(string respuesta)
        {
            if (respuesta == correcta) return true;
            else return false;

        }








































    }
}
