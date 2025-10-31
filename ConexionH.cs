using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ADL_Controles
{
    internal class ConexionH
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "Hotel";
            string usuario = "root";
            string password = "rooot";
            //se crea la cadena conexión con los datos anteriormente guardados
            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";

            try //se intenta la coneccion
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message); //en caso de que no se conecte a mysql da este mensaje
                return null;
            }
        }
    }
}
