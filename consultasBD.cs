using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFTT_ProyectoParcial1
{
    public static class ConsultasBD
    {
        public static bool InsertarCancion(string nomcan, string duracion, string album, string artista, string anio, string genero)
        {
            string sql = "INSERT INTO playcan (nombre_cancion, Duracion, Album, Artista, Anio, Genero) " +
                         "VALUES (@nombre, @duracion, @album, @artista, @anio, @genero)";
            MySqlConnection conexionBD = conexion.conexionp();
            if (conexionBD == null) return false;

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("@nombre", nomcan);
                comando.Parameters.AddWithValue("@duracion", duracion);
                comando.Parameters.AddWithValue("@album", album);
                comando.Parameters.AddWithValue("@artista", artista);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters.AddWithValue("@genero", genero);
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al insertar la canción: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open) conexionBD.Close();
            }
        }

        public static DataTable BuscarCancion(string nombreCancion)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT id, nombre_cancion, Duracion, Album, Artista, Anio, Genero FROM playcan WHERE nombre_cancion = @nombre";

            MySqlConnection conexionBD = conexion.conexionp();
            if (conexionBD == null) return dt;

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("@nombre", nombreCancion);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar la canción: " + ex.Message);
                return dt;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open) conexionBD.Close();
            }
        }
        public static bool EliminarCancion(string nombreCancion)
        {
            // SQL: DELETE FROM [nombre_tabla] WHERE [columna] = [valor]
            string sql = "DELETE FROM playcan WHERE nombre_cancion = @nombre";

            // Nota: Usando el método de conexión que has estado usando
            MySqlConnection conexionBD = conexion.conexionp();
            if (conexionBD == null) return false;

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                // Uso de parámetros
                comando.Parameters.AddWithValue("@nombre", nombreCancion);

                int filasAfectadas = comando.ExecuteNonQuery();

                // Si filasAfectadas es > 0, significa que se borró al menos un registro
                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar la canción: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
        public static bool ActualizarCancion(int id, string nombre, string duracion, string album, string artista, string anio, string genero)
        {
            string sql = "UPDATE playcan SET nombre_cancion=@nombre, Duracion=@duracion, Album=@album, Artista=@artista, Anio=@anio, Genero=@genero " +
                         "WHERE id=@id";

            MySqlConnection conexionBD = conexion.conexionp();
            if (conexionBD == null) return false;

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@duracion", duracion);
                comando.Parameters.AddWithValue("@album", album);
                comando.Parameters.AddWithValue("@artista", artista);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters.AddWithValue("@genero", genero);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar la canción: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
    }
}