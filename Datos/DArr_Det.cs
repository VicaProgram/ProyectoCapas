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
    public class DArr_Det
    {
        private Conexion Cn = new Conexion();

        public static DArr_Det _instancia = null;

        public static DArr_Det Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArr_Det();
                }
                return _instancia;
            }
        }

        public bool Ingresar(EArr_Det obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Arr_Det", Con);
                    cmd.Parameters.AddWithValue("DPr1", obj.DPr1);
                    cmd.Parameters.AddWithValue("DPr2", obj.DPr2);
                    cmd.Parameters.AddWithValue("DPr3", obj.DPr3);
                    cmd.Parameters.AddWithValue("DPr4", obj.DPr4);
                    cmd.Parameters.AddWithValue("DPr5", obj.DPr5);
                    cmd.Parameters.AddWithValue("DPr6", obj.DPr6);
                    cmd.Parameters.AddWithValue("DPr7", obj.DPr7);
                    cmd.Parameters.AddWithValue("DPr8", obj.DPr8);
                    cmd.Parameters.AddWithValue("DPr9", obj.DPr9);
                    cmd.Parameters.AddWithValue("DPr10", obj.DPr10);
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

                    SqlCommand cmd = new SqlCommand("Ult_Arr_Det", Con); //LLama al Procedimiento Almacenado
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
