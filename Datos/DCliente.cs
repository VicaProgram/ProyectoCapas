using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class DCliente //Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DCliente _instancia = null; //Declara Variable

        public static DCliente Instancia //Declara Propiedad
        {
            get 
            {
                if (_instancia == null)  //Si es nulo
                {
                    _instancia = new DCliente(); //Crea una nueva instancia
                }
                return _instancia; //Sino devuelve la instancia
            }
        }

        public List<ECliente> Listar() //Declara Metodo
        {
            List<ECliente> Lis = new List<ECliente>(); //Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_Cliente", oConexion); //LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                try
                {
                    oConexion.Open(); //Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el procedimiento linea por linea
                    while (dr.Read()) //Mientras Lee
                    {
                        Lis.Add(new ECliente() // Agrega un instancia a la lista
                        {
                            IdP_Cli = Convert.ToInt32(dr["IdP_Cli"].ToString()), //Extrae el valor y lo almacena
                            Nombre = dr["Nombre"].ToString(), //Extrae el valor y lo almacena
                            Rut = dr["Rut"].ToString(), //Extrae el valor y lo almacena
                            IdReg = Convert.ToInt32(dr["IdReg"].ToString()), //Extrae el valor y lo almacena
                            Reg = new ELocReg() { Nombre = dr["NombreRegion"].ToString() }, //Extrae el valor y lo almacena
                            IdPro = Convert.ToInt32(dr["IdPro"].ToString()), //Extrae el valor y lo almacena
                            Pro = new ELocPro() { Nombre = dr["NombreProvincia"].ToString() }, //Extrae el valor y lo almacena
                            IdCom = Convert.ToInt32(dr["IdCom"].ToString()), //Extrae el valor y lo almacena
                            Com = new ELocCom() { Nombre = dr["NombreComuna"].ToString() }, //Extrae el valor y lo almacena
                            Direccion = dr["Direccion"].ToString(), //Extrae el valor y lo almacena
                            Tel = dr["Tel"].ToString(), //Extrae el valor y lo almacena
                            Email = dr["Email"].ToString(), //Extrae el valor y lo almacena
                            Giro = dr["Giro"].ToString(), //Extrae el valor y lo almacena
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
        public bool Buscar(ECliente obj) //Declara Metodo
        {
            bool Respuesta = true;  //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Bus_Rut_Cliente", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Rut", obj.Rut); //Le asigna un valor al objeto
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //LLama al Procedimiento Almacenado
                    Con.Open(); //Abre conexion
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

        public bool Ingresar(ECliente obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Cliente", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Rut", obj.Rut); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Tel", obj.Tel); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Email", obj.Email); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Giro", obj.Giro); //Le asigna un valor al objeto
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

        public bool Actualizar(ECliente obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Cliente", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdP_Cli", obj.IdP_Cli); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Rut", obj.Rut); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Tel", obj.Tel); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Email", obj.Email); //Le asigna un valor al objeto
                    cmd.Parameters.AddWithValue("Giro", obj.Giro); //Le asigna un valor al objeto
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
                    SqlCommand cmd = new SqlCommand("Eli_Cliente", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdP_Cli", Id); //Pasa el valor
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

        public int ObtenerUltimoId() //Declara Metodo
        {
            int ultimoId = 0; //Declara variable

            try //Incio Bloque
            {
                using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion DB
                {
                    Con.Open(); //Abre conexion

                    SqlCommand cmd = new SqlCommand("Ult_Cliente", Con); //LLama al Procedimiento Almacenado
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