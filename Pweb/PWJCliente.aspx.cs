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
	public partial class PWJCliente : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        // Se expone este método como un web service que puede invocarse vía HTTP GET.
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static Respuesta<List<ECliente>> Obtener()
        {
            // Se declara e inicializa una lista de objetos ECliente.
            List<ECliente> Listar = new List<ECliente>();

            // Se asigna a la lista el resultado del método Listar() de la capa de negocio NCliente.
            Listar = new NCliente().Listar();

            // Si la lista no es nula, se envuelve en un objeto respuesta indicando estado exitoso.
            if (Listar != null)
            {
                return new Respuesta<List<ECliente>>()
                {
                    estado = true,    // Indica éxito.
                    objeto = Listar   // Devuelve la lista de clientes.
                };
            }
            else
            {
                // En caso de no obtener registros, se devuelve una respuesta con estado fallido.
                return new Respuesta<List<ECliente>>()
                {
                    estado = false,   // Indica que ocurrió un error o no hay datos.
                    objeto = null     // No devuelve objeto.
                };
            }
        }

        // Método web para filtrar provincias según el ID de una región.
        // Recibe el parámetro IdReg y devuelve una lista de objetos ELocPro.
        [WebMethod]
        public static List<ELocPro> FiltrarReg(int IdReg)
        {
            // Se declara la lista donde se almacenarán las provincias filtradas.
            List<ELocPro> Provincias = new List<ELocPro>();

            // Se obtiene un DataTable con la información filtrada mediante la capa de negocio NLocPro.
            DataTable dt = new NLocPro().Filtrar(IdReg);

            // Se itera cada fila del DataTable para transformar los datos en un objeto ELocPro.
            foreach (DataRow row in dt.Rows)
            {
                // Se crea un objeto de tipo ELocPro con sus propiedades obtenidas de la fila.
                ELocPro Provincia = new ELocPro
                {
                    IdPro = Convert.ToInt32(row["IdPro"]),  // Convierte el valor de "IdPro" a entero.
                    Nombre = row["Nombre"].ToString()        // Convierte el valor de "Nombre" a string.
                };
                // Se agrega el objeto provincia a la lista.
                Provincias.Add(Provincia);
            }
            // Se retorna la lista de provincias filtradas.
            return Provincias;
        }

        // Método web para filtrar comunas según el ID de una provincia.
        // Recibe el parámetro IdPro y devuelve una lista de objetos ELocCom.
        [WebMethod]
        public static List<ELocCom> FiltrarPro(int IdPro)
        {
            // Se declara la lista donde se almacenarán las comunas filtradas.
            List<ELocCom> Comunas = new List<ELocCom>();

            // Se obtiene un DataTable con la información filtrada mediante la capa de negocio NLocCom.
            DataTable dt = new NLocCom().Filtrar(IdPro);

            // Se itera cada fila del DataTable para transformar los datos en un objeto ELocCom.
            foreach (DataRow row in dt.Rows)
            {
                // Se crea un objeto de tipo ELocCom con sus propiedades extraídas de la fila.
                ELocCom Comuna = new ELocCom
                {
                    IdCom = Convert.ToInt32(row["IdCom"]),  // Convierte el valor de "IdCom" a entero.
                    Nombre = row["Nombre"].ToString()         // Convierte el valor de "Nombre" a string.
                };
                // Se agrega el objeto comuna a la lista.
                Comunas.Add(Comuna);
            }
            // Se retorna la lista de comunas filtradas.
            return Comunas;
        }

        // Método web para ingresar un nuevo cliente.
        // Recibe un objeto ECliente y retorna una respuesta indicando el éxito de la operación.
        [WebMethod]
        public static Respuesta<bool> Ingresar(ECliente obj)
        {
            // Se delega la inserción en la capa de negocio NCliente y se retorna la respuesta.
            return NCliente.Ingresar(obj);
        }

        // Método web para actualizar la información de un cliente existente.
        // Recibe un objeto ECliente y retorna una respuesta indicando el éxito de la actualización.
        [WebMethod]
        public static Respuesta<bool> Actualizar(ECliente obj)
        {
            // Se delega la actualización en la capa de negocio NCliente y se retorna la respuesta.
            return NCliente.Actualizar(obj);
        }

        // Método web para eliminar un cliente dado su ID (IdP_Cli).
        // Devuelve una respuesta indicando si la eliminación fue exitosa.
        [WebMethod]
        public static Respuesta<bool> Eliminar(int IdP_Cli)
        {
            // Se delega la eliminación en la capa de negocio NCliente y se retorna la respuesta.
            return NCliente.Eliminar(IdP_Cli);
        }

    }
}