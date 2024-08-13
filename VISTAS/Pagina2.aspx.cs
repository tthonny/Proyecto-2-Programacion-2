
using ExamenProgra2.CapaAccesoDatos;
using ExamenProgra2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ExamenProgra2.VISTAS
{
    public partial class Pagina2 : System.Web.UI.Page
    { 


        protected void Page_Load(object sender, EventArgs e)
        {
         
          
        }


        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles de texto y convertirlos según sea necesario
                 Clvotantess.cedula = Convert.ToInt32(txtCedula.Text);
                Clvotantess.nombre = txtNombre.Text;
                Clvotantess.apellido1 = txtApellido1.Text;
                Clvotantess.apellido2 = txtApellido2.Text;
                Clvotantess.ubicacion = txtUbicacion.Text;
                Clvotantess.edad = Convert.ToInt32(txtEdad.Text);

                // Llamar al método IngresarDatos para insertar los datos en la base de datos
                RepositorioVotaciones.IngresarDatosVotant(Clvotantess.cedula, Clvotantess.nombre, Clvotantess.apellido1, Clvotantess.apellido2, Clvotantess.ubicacion, Clvotantess.edad);

                // Mostrar mensaje de éxito o realizar otras acciones después de insertar los datos
                // Por ejemplo:
                Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }

       
       
    }
}

