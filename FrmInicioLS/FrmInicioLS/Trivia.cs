using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmInicioLS
{
    class Trivia
    {
        private Pregunta[] preguntas;
        private Pregunta preguntaActual;

        public Trivia()
        {

            preguntas = PreguntasRepository.getPreguntas();
            NuevaPregunta();

        }

        public void NuevaPregunta()
        {
            Random azar = new Random();
            int cual = azar.Next(0, preguntas.Length);
            preguntaActual = preguntas[cual];

        }

        public Pregunta getPregunta()
        {
            return preguntaActual;
        }























    }
}
