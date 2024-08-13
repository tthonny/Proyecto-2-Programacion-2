using ExamenProgra2.CapaAccesoDatos;
using ExamenProgra2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenProgra2.VISTAS
{
    public partial class Pagina3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles de texto y convertirlos según sea necesario
                Clelectos.cedula = Convert.ToInt32(txtCedula.Text);
                Clelectos.nombre = txtNombre.Text;
                Clelectos.apellido1 = txtApellido1.Text;
                Clelectos.apellido2 = txtApellido2.Text;
                Clelectos.ubicacion = txtUbicacion.Text;
                Clelectos.edad = Convert.ToInt32(txtEdad.Text);
                Clelectos.partidopo = txtPartidoPo.Text;

                // Llamar al método IngresarDatos para insertar los datos en la base de datos
                RepositorioVotaciones.IngresarDatosElect(Clelectos.cedula, Clelectos.nombre, Clelectos.apellido1, Clelectos.apellido2, Clelectos.ubicacion, Clelectos.edad, Clelectos.partidopo);

                // Mostrar mensaje de éxito o realizar otras acciones después de insertar los datos
                
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