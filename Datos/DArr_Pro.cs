using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArr_Pro
    {
        private Conexion Cn = new Conexion();

        public static DArr_Pro _instancia = null;

        public static DArr_Pro Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArr_Pro();
                }
                return _instancia;
            }
        }

        public bool Ingresar(EArr_Pro obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Arr_Pro", Con);
                    cmd.Parameters.AddWithValue("IdP_Prod1", obj.IdP_Prod1);
                    cmd.Parameters.AddWithValue("IdP_Prod1", obj.IdP_Prod2);
                    cmd.Parameters.AddWithValue("IdP_Prod3", obj.IdP_Prod3);
                    cmd.Parameters.AddWithValue("IdP_Prod4", obj.IdP_Prod4);
                    cmd.Parameters.AddWithValue("IdP_Prod5", obj.IdP_Prod5);
                    cmd.Parameters.AddWithValue("IdP_Prod6", obj.IdP_Prod6);
                    cmd.Parameters.AddWithValue("IdP_Prod7", obj.IdP_Prod7);
                    cmd.Parameters.AddWithValue("IdP_Prod8", obj.IdP_Prod8);
                    cmd.Parameters.AddWithValue("IdP_Prod9", obj.IdP_Prod9);
                    cmd.Parameters.AddWithValue("IdP_Prod10", obj.IdP_Prod10);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception)
                {
                    Respuesta = false;
                }
            }
            return Respuesta;
        }
        public int ObtenerUltimoId() //Declara Metodo
        {
            int ultimoId = 0; //Declara variable

            try //Incio Bloque
            {
                using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
                {
                    Con.Open(); //Abre conexion

                    SqlCommand cmd = new SqlCommand("Ult_Arr_Pro", Con); //LLama al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    object resultado = cmd.ExecuteScalar();  //Le asigna un valor al objeto

                    if (resultado != null && resultado != DBNull.Value) //Pregunta si es nulo
                    {
                        ultimoId = Convert.ToInt32(resultado); //Almacena resultado como int32 en ultimoId
                    }
                }
            }
            catch (Exception ex) //Incio Bloque
            {
                Console.WriteLine($"Error en capa de datos: {ex.Message}"); //Mensaje consola
                throw; //Lanza denuevo la Excepcion
            }

            return ultimoId; //Devuelve ultimoId
        }
    }
}
