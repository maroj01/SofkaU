using MySql.Data.MySqlClient;
using System;

namespace RetoSofka
{
    internal class RetoBd
    {

        public MySqlDataReader consultarPregunta(int categoria)
        {
            MySqlConnection cnx = ConexionBd.getconexion();
            cnx.Open();
            MySqlDataReader reader = null;

            string categoriaStr = Convert.ToString(categoria);

            int pregunta;
            var semilla = Environment.TickCount;
            Random numero = new Random(semilla);
            pregunta = numero.Next(1, 6);
            string preguntaStr = Convert.ToString(pregunta);

            string sql = "SELECT * FROM preguntas WHERE Id_Pregunta = '" + preguntaStr + "' AND Categoria = '" + categoriaStr + "' ";
            MySqlCommand comando = new MySqlCommand(sql, cnx);

            reader = comando.ExecuteReader();
            return reader;
        }

        public void registrarParticipante(Participante jugador)
        {
            MySqlConnection cnx = ConexionBd.getconexion();
            cnx.Open();
            string sql = "INSERT INTO participante (Nombre,Puntaje) VALUES(@nombre,@puntaje)";
            MySqlCommand comando = new MySqlCommand(sql, cnx);
            comando.Parameters.AddWithValue("@nombre", jugador.Nombre1);
            comando.Parameters.AddWithValue("@puntaje", jugador.Puntaje1);
            comando.ExecuteNonQuery();
        }
    }
}