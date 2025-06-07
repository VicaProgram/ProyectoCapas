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
   public partial class PWJLocRegi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)// Se ejecuta cuando se carga la página.
        {
        }
        [WebMethod]// Método web
        [ScriptMethod(UseHttpGet = true)]
        public static Respuesta<List<ELocReg>> Obtener()
        {
            // Crea la lista de registros.
            List<ELocReg> Listar = new List<ELocReg>();
            // Llama al método que obtiene todos los registros.
            Listar = new NLocReg().Listar();

            // Si obtuvo registros, retorna éxito; si no, retorna fallo.
            if (Listar != null)
            {
                return new Respuesta<List<ELocReg>>()
                {
                    estado = true,
                    objeto = Listar
                };
            }
            else
            {
                return new Respuesta<List<ELocReg>>()
                {
                    estado = false,
                    objeto = null
                };
            }
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Ingresar(ELocReg obj)
        {
            // Llama a la función para ingresar nuevo registro.
            return NLocReg.Ingresar(obj);
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Actualizar(ELocReg obj)
        {
            // Llama a la función para actualizar.
            return NLocReg.Actualizar(obj);
        }
        [WebMethod]// Método web
        public static Respuesta<bool> Eliminar(int IdReg)
        {
            return NLocReg.Eliminar(IdReg);// Llama a la función eliminar.
        }
    }
}