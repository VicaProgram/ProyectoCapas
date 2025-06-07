using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pweb
{
	public partial class PWJProd : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        [WebMethod] // Expone este método como servicio web.
        [ScriptMethod(UseHttpGet = true)] // Configurado para recibir solicitudes GET.
        public static Respuesta<List<EProd>> Obtener()
        {
            // Inicializa y asigna la lista de productos.
            List<EProd> Listar = new List<EProd>();
            Listar = new NProd().Listar();

            // Comprueba si se recuperó la lista y retorna la respuesta adecuada.
            if (Listar != null)
            {
                return new Respuesta<List<EProd>>()
                {
                    estado = true,
                    objeto = Listar
                };
            }
            else
            {
                return new Respuesta<List<EProd>>()
                {
                    estado = false,
                    objeto = null
                };
            }
        }

        [WebMethod] // Servicio para agregar un producto.
        public static Respuesta<bool> Ingresar(EProd obj)
        {
            // Llama la lógica de negocio para insertar el producto.
            return NProd.Ingresar(obj);
        }

        [WebMethod] // Servicio para actualizar un producto.
        public static Respuesta<bool> Actualizar(EProd obj)
        {
            // Llama la lógica de negocio para actualizar el producto.
            return NProd.Actualizar(obj);
        }

        [WebMethod] // Servicio para eliminar un producto.
        public static Respuesta<bool> Eliminar(int IdProd)
        {
            // Llama la lógica de negocio para eliminar el producto.
            return NProd.Eliminar(IdProd);
        }

    }
}