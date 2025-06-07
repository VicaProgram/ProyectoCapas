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
	public partial class PWJProv : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        // Método expuesto como WebMethod y accesible vía HTTP GET
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static Respuesta<List<EProv>> Obtener()
        {
            // Se instancia una lista de objetos EProv
            List<EProv> Listar = new List<EProv>();

            // Se llena la lista llamando a la capa de negocio de proveedores (NProv)
            Listar = new NProv().Listar();

            // Si se obtuvo la lista (no es nula), se retorna una respuesta indicando éxito
            if (Listar != null)
            {
                return new Respuesta<List<EProv>>()
                {
                    estado = true,    // Estado verdadero, indicando éxito
                    objeto = Listar   // Se retorna la lista de proveedores
                };
            }
            else
            {
                // Si no se obtuvo la lista, se retorna una respuesta con estado false y objeto nulo
                return new Respuesta<List<EProv>>()
                {
                    estado = false,
                    objeto = null
                };
            }
        }

        // Método para filtrar provincias según el ID de la región (IdReg)
        [WebMethod]
        public static List<ELocPro> FiltrarReg(int IdReg)
        {
            // Se declara una lista para almacenar las provincias filtradas
            List<ELocPro> Provincias = new List<ELocPro>();

            // Se obtiene la información filtrada de la capa de negocio (NLocPro)
            DataTable dt = new NLocPro().Filtrar(IdReg);

            // Se recorre cada fila del DataTable para crear objetos ELocPro
            foreach (DataRow row in dt.Rows)
            {
                ELocPro Provincia = new ELocPro
                {
                    IdPro = Convert.ToInt32(row["IdPro"]),  // Se convierte el valor a entero
                    Nombre = row["Nombre"].ToString()        // Se convierte el valor a string
                };
                Provincias.Add(Provincia); // Se agrega la provincia a la lista
            }
            // Se retorna la lista de provincias filtradas
            return Provincias;
        }

        // Método para filtrar comunas según el ID de la provincia (IdPro)
        [WebMethod]
        public static List<ELocCom> FiltrarPro(int IdPro)
        {
            // Se declara una lista para almacenar las comunas filtradas
            List<ELocCom> Comunas = new List<ELocCom>();

            // Se obtiene un DataTable con las comunas filtradas mediante la capa de negocio (NLocCom)
            DataTable dt = new NLocCom().Filtrar(IdPro);

            // Se recorre cada fila del DataTable para crear objetos ELocCom
            foreach (DataRow row in dt.Rows)
            {
                ELocCom Comuna = new ELocCom
                {
                    IdCom = Convert.ToInt32(row["IdCom"]),  // Convierte a entero el valor de IdCom
                    Nombre = row["Nombre"].ToString()         // Convierte a string el valor de Nombre
                };
                Comunas.Add(Comuna); // Se agrega la comuna a la lista
            }
            // Se retorna la lista de comunas filtradas
            return Comunas;
        }

        // Método para ingresar un nuevo proveedor
        [WebMethod]
        public static Respuesta<bool> Ingresar(EProv obj)
        {
            // Se delega el ingreso del objeto EProv a la capa de negocio (NProv)
            return NProv.Ingresar(obj);
        }

        // Método para actualizar la información de un proveedor existente
        [WebMethod]
        public static Respuesta<bool> Actualizar(EProv obj)
        {
            // Se delega la actualización a la capa de negocio (NProv) y se retorna la respuesta
            return NProv.Actualizar(obj);
        }

        // Método para eliminar un proveedor dado su ID (IdProv)
        [WebMethod]
        public static Respuesta<bool> Eliminar(int IdProv)
        {
            // Se delega la eliminación en la capa de negocio (NProv) y se retorna la respuesta
            return NProv.Eliminar(IdProv);
        }

    }
}