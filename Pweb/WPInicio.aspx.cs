using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pweb
{
	public partial class WPInicio : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        [WebMethod] // Método web
        [ScriptMethod(UseHttpGet = true)] // Define que se puede invocar usando el método GET.
        public static Respuesta<bool> CerrarSesion()
        {
            Configuracion.Ent = null; // Cierra la sesión.

            return new Respuesta<bool>() { estado = true }; // Retorna una respuesta indicando que se cerró la sesión correctamente.
        }

    }
}