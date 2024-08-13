using ExamenProgra2.CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenProgra2.VISTAS
{
    public partial class Pagina_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              CargarDatos();
            }
        }
        private void CargarDatos()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT electos, votos FROM totalvotos";

                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        // Construir el HTML dinámicamente
                        string rows = "";
                        while (reader.Read())
                        {
                            rows += $"<tr><td>{HttpUtility.HtmlEncode(reader["electos"].ToString())}</td><td>{HttpUtility.HtmlEncode(reader["votos"].ToString())}</td></tr>";
                        }

                        // Insertar las filas en el cuerpo de la tabla
                        votosTabla.InnerHtml = rows;
                    }
                }
            }
        }
    }
}