using Entidad;
using Negocio;
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
	public partial class PWJLocProv : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        [WebMethod]// Método web
        [ScriptMethod(UseHttpGet = true)]
        public static Respuesta<List<ELocPro>> Obtener()
        {
            // Crea la lista de registros.
            List<ELocPro> Listar = new List<ELocPro>();
            // Llama al método que obtiene todos los registros.
            Listar = new NLocPro().Listar();

            // Si obtuvo registros, retorna éxito; si no, retorna fallo.
            if (Listar != null)
            {
                return new Respuesta<List<ELocPro>>()
                {
                    estado = true,
                    objeto = Listar
                };
            }
            else
            {
                return new Respuesta<List<ELocPro>>()
                {
                    estado = false,
                    objeto = null
                };
            }
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Ingresar(ELocPro obj)
        {
            // Llama a la función para ingresar nuevo registro.
            return NLocPro.Ingresar(obj);
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Actualizar(ELocPro obj)
        {
            // Llama a la función para actualizar.
            return NLocPro.Actualizar(obj);
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Eliminar(int IdPro)
        {
            return NLocPro.Eliminar(IdPro);// Llama a la función eliminar.
        }

    }
}