using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace capa_Datos
{
    public class Class1
    {
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5433;
            string usuario = "postgres";
            string clave = "sa123456";
            string baseDatos = "sistema";

            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);

        }
    }
}