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
    public class DArr_VUn
    {
        private Conexion Cn = new Conexion();

        public static DArr_VUn _instancia = null;

        public static DArr_VUn Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArr_VUn();
                }
                return _instancia;
            }
        }

        public bool Ingresar(EArr_VUn obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Arr_VUn", Con);
                    cmd.Parameters.AddWithValue("VUn1", obj.VUn1);
                    cmd.Parameters.AddWithValue("VUn2", obj.VUn2);
                    cmd.Parameters.AddWithValue("VUn3", obj.VUn3);
                    cmd.Parameters.AddWithValue("VUn4", obj.VUn4);
                    cmd.Parameters.AddWithValue("VUn5", obj.VUn5);
                    cmd.Parameters.AddWithValue("VUn6", obj.VUn6);
                    cmd.Parameters.AddWithValue("VUn7", obj.VUn7);
                    cmd.Parameters.AddWithValue("VUn8", obj.VUn8);
                    cmd.Parameters.AddWithValue("VUn9", obj.VUn9);
                    cmd.Parameters.AddWithValue("VUn10", obj.VUn10);
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

        /* public bool Actualizar(EArr_VUn obj)
         {
             bool Respuesta = true;
             using (SqlConnection Con = new SqlConnection(Conexion.Conex))
             {
                 try
                 {
                     SqlCommand cmd = new SqlCommand("Act_Arr_VUn", Con);
                     cmd.Parameters.AddWithValue("IdAVUn", obj.IdAVUn);
                     cmd.Parameters.AddWithValue("IdP_Cli", obj.IdP_Cli);
                     cmd.Parameters.AddWithValue("Fech", obj.Fech);
                     cmd.Parameters.AddWithValue("VUn1", obj.VUn1);
                     cmd.Parameters.AddWithValue("VUn2", obj.VUn2);
                     cmd.Parameters.AddWithValue("VUn3", obj.VUn3);
                     cmd.Parameters.AddWithValue("VUn4", obj.VUn4);
                     cmd.Parameters.AddWithValue("VUn5", obj.VUn5);
                     cmd.Parameters.AddWithValue("VUn6", obj.VUn6);
                     cmd.Parameters.AddWithValue("VUn7", obj.VUn7);
                     cmd.Parameters.AddWithValue("VUn8", obj.VUn8);
                     cmd.Parameters.AddWithValue("VUn9", obj.VUn9);
                     cmd.Parameters.AddWithValue("VUn10", obj.VUn10);
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
         }*/
        public int ObtenerUltimoId() //Declara Metodo
        {
            int ultimoId = 0; //Declara variable

            try //Incio Bloque
            {
                using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
                {
                    Con.Open(); //Abre conexion

                    SqlCommand cmd = new SqlCommand("Ult_Arr_VUn", Con); //LLama al Procedimiento Almacenado
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
