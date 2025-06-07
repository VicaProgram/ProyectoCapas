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
    public partial class PWJLocComu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static Respuesta<List<ELocCom>> Obtener()
        {
            List<ELocCom> Listar = new List<ELocCom>();
            Listar = new NLocCom().Listar();
            if (Listar != null)
            {
                return new Respuesta<List<ELocCom>>()
                {
                    estado = true,
                    objeto = Listar
                };
            }
            else
            {
                return new Respuesta<List<ELocCom>>()
                {
                    estado = false,
                    objeto = null
                };
            }
        }

        [WebMethod]
        public static List<ELocPro> Filtrar(int IdReg)
        {
            List<ELocPro> provincias = new List<ELocPro>();
            DataTable dt = new NLocPro().Filtrar(IdReg);
            foreach (DataRow row in dt.Rows)
            {
                ELocPro provincia = new ELocPro
                {
                    IdPro = Convert.ToInt32(row["IdPro"]),
                    Nombre = row["Nombre"].ToString()
                };
                provincias.Add(provincia);
            }
            return provincias;
        }

        [WebMethod]
        public static Respuesta<bool> Ingresar(ELocCom obj)
        {
            return NLocCom.Ingresar(obj);
        }
        [WebMethod]
        public static Respuesta<bool> Actualizar(ELocCom obj)
        {
            return NLocCom.Actualizar(obj);
        }
        [WebMethod]
        public static Respuesta<bool> Eliminar(int IdCom)
        {
            return NLocCom.Eliminar(IdCom);
        }
    }
}