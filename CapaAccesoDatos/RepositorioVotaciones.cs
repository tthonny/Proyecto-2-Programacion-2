using ExamenProgra2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenProgra2.CapaAccesoDatos
{
    public static class RepositorioVotaciones
    {
      

      
        //Metodo para ingresar votantes 
        public static void IngresarDatosVotant(int cedula, string nombre, string apellido1, string apellido2, string ubicacion, int edad)
        {
            // Consulta SQL para insertar datos en la tabla votantes
            string query = "INSERT INTO votantes (cedula, nombre, apellido1, apellido2, ubicacion, edad) " +
                           "VALUES (@cedula, @nombre, @apellido1, @apellido2, @ubicacion, @edad)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@cedula", Clvotantess.cedula);
                    comando.Parameters.AddWithValue("@nombre", Clvotantess.nombre);
                    comando.Parameters.AddWithValue("@apellido1", Clvotantess.apellido1);
                    comando.Parameters.AddWithValue("@apellido2", Clvotantess.apellido2);
                    comando.Parameters.AddWithValue("@ubicacion", Clvotantess.ubicacion);
                    comando.Parameters.AddWithValue("@edad", Clvotantess.edad);

                    // Ejecutar el comando SQL para insertar los datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }

        //Metodo para ingresar electos
        public static void IngresarDatosElect(int cedula, string nombre, string apellido1, string apellido2, string ubicacion, int edad, string partidopo)
        {
            // 
            string query = "INSERT INTO electos (cedula, nombre, apellido1, apellido2, ubicacion, edad , partidopo) " +
                           "VALUES (@cedula, @nombre, @apellido1, @apellido2, @ubicacion, @edad,@partidopo)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@cedula", Clelectos.cedula);
                    comando.Parameters.AddWithValue("@nombre", Clelectos.nombre);
                    comando.Parameters.AddWithValue("@apellido1", Clelectos.apellido1);
                    comando.Parameters.AddWithValue("@apellido2", Clelectos.apellido2);
                    comando.Parameters.AddWithValue("@ubicacion", Clelectos.ubicacion);
                    comando.Parameters.AddWithValue("@edad", Clelectos.edad);
                    comando.Parameters.AddWithValue("@partidopo", Clelectos.partidopo);

                    // Ejecutar el comando SQL para insertar los datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }



        //Metodo para ingresar los votos
        public static void IngresarDatosVts(int votar, int votarNulo)
        {
            // Consulta SQL para insertar datos en la tabla votos
            string query = "INSERT INTO votos (votar, votarNulo) " +
                           "VALUES (@CANTIDAD_VOTOS, @CANTIDAD_NULOS)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@CANTIDAD_VOTOS", Votos.votar);
                    comando.Parameters.AddWithValue("@CANTIDAD_NULOS", Votos.votarNulo);


                    // Ejecutar el comando SQL para insertar los datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }

       

    }
}