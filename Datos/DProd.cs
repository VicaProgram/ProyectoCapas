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
    public class DProd//Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DProd _instancia = null; //Declara Variable

        public static DProd Instancia //Declara Propiedad
        {
            get
            {
                if (_instancia == null)  //Si es nulo
                {
                    _instancia = new DProd(); //Crea una nueva instancia
                }
                return _instancia; //Sino devuelve la instancia
            }
        }
        public List<EProd> Listar() //Declara Metodo
        {
            List<EProd> Lis = new List<EProd>(); //Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_Prod", oConexion); //LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                try
                {
                    oConexion.Open(); //Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el procedimiento linea por linea
                    while (dr.Read()) //Mientras Lee
                    {
                        Lis.Add(new EProd() // Agrega un instancia a la lista
                        {
                            IdProd = Convert.ToInt32(dr["IdProd"].ToString()), //Extrae el valor y lo almacena
                            Nombre = dr["Nombre"].ToString(), //Extrae el valor y lo almacena
                            FInc = dr["FInc"].ToString(), //Extrae el valor y lo almacena
                            CInc = dr["CInc"].ToString(), //Extrae el valor y lo almacena
                            CAct = dr["CAct"].ToString(), //Extrae el valor y lo almacena
                            CArr = dr["CArr"].ToString(), //Extrae el valor y lo almacena
                            TAct = dr["TAct"].ToString(), //Extrae el valor y lo almacena
                            VArr = dr["VArr"].ToString(), //Extrae el valor y lo almacena
                        });
                    }
                    dr.Close(); //Termina de leer
                    return Lis; //devuelve la lista
                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Lis = null; //Le asigna el valor null a la lista
                    return Lis; //Devuelve la lista
                }
            }
        }
        public bool Ingresar(EProd obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Prod", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("FInc", obj.FInc); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CInc", obj.CInc); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CAct", obj.CAct); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CArr", obj.CArr); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("TAct", obj.TAct); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("VArr", obj.VArr); //Le asigna un valor al objeto
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    Con.Open(); //Abre conexion
                    cmd.ExecuteNonQuery(); //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //Le asigna un valor
                }
                catch (Exception)
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }
        public bool Actualizar(EProd obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Prod", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProd", obj.IdProd); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("FInc", obj.FInc); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CInc", obj.CInc); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CAct", obj.CAct); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CArr", obj.CArr); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("TAct", obj.TAct); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("VArr", obj.VArr); //Le asigna un valor al objeto
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    Con.Open();  //Abre conexion
                    cmd.ExecuteNonQuery(); //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //Le asigna un valor

                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }
        public bool Actualizar2(EProd obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Prod2", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProd", obj.IdProd); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("CArr", obj.CArr); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("TAct", obj.TAct); //Le asigna un valor al objeto
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    Con.Open();  //Abre conexion
                    cmd.ExecuteNonQuery(); //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //Le asigna un valor

                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }
        public bool Eliminar(int Id) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Prod", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProd", Id); //Pasa el valor
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    Con.Open(); //Abre conexion
                    cmd.ExecuteNonQuery();  //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //Le asigna un valor
                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }

    }
}
