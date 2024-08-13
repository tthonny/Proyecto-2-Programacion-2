using ExamenProgra2.CapaAccesoDatos;using ExamenProgra2.Modelo;using System;using System.Collections.Generic;using System.Configuration;using System.Data.SqlClient;using System.Linq;using System.Security.Policy;using System.Web;using System.Web.UI;using System.Web.UI.WebControls;namespace ExamenProgra2.VISTAS{    public partial class Pagina_4 : System.Web.UI.Page    {


        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
            


                if (rbVotar.Checked)
                {
                  Votos.votar = 1;
                    Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
                }
                else if (rbVotarNulo.Checked)
                {

                    Votos.votarNulo =1;
                    Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
                }

                RepositorioVotaciones.IngresarDatosVts(Votos.votar,Votos.votarNulo);
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

    


