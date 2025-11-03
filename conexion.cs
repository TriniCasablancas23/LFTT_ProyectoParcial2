using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFTT_ProyectoParcial1
{
    internal class conexion
    {
        public static MySqlConnection conexionp()
        {
            string servidor = "localhost";
            string bd = "playlist";
            string usuario = "root";
            string password = "hola";
            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
