using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pweb
{
	public partial class WPLogin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		[WebMethod]// Método web
        public static Respuesta<bool> Verificar(string Nombre, string Pass) 
		{
			EUsua Ent = new EUsua // Crea un objeto EUsua
            {
				Nombre = Nombre, // Asigna el nombre
                Pass = Pass // Asigna la contraseña
            };
			return NUsua.Verificar(Ent); // Llama al método 
        }
	}
}