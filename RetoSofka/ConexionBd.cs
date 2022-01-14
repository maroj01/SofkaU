using MySql.Data.MySqlClient;

namespace RetoSofka
{
    internal class ConexionBd
    {
        public static MySqlConnection getconexion()
        {
            MySqlConnection conexion = new MySqlConnection("Database=challenge; Server=localhost; Port=3306; Uid=root; Pwd=;");
            return conexion;
        }
    }
}