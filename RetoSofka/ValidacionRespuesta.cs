using System;

namespace RetoSofka
{
    internal class ValidacionRespuesta
    {
        public Boolean comprobarRespuesta(string respuestaJugador, string respuestaCorrecta)
        {
            Boolean resultado;
            if (respuestaJugador == respuestaCorrecta)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}