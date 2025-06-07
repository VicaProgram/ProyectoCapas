using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class DProv //Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DProv _instancia = null;//Declara Variable

        public static DProv Instancia//Declara Propiedad
        {
            get
            {
                if (_instancia == null)//Si es nulo
                {
                    _instancia = new DProv();//Crea una nueva instancia
                }
                return _instancia;//Sino devuelve la instancia
            }
        }

        public List<EProv> Listar()//Declara Metodo
        {
            List<EProv> Lis = new List<EProv>();//Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))//Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_Prov", oConexion); //LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                try //bloque try
                {
                    oConexion.Open(); //Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el procedimiento linea por linea
                    while (dr.Read()) //Mientras Lee
                    {
                        Lis.Add(new EProv() // Agrega un instancia a la lista
                        {
                            IdProv = Convert.ToInt32(dr["IdProv"].ToString()), //Extrae el valor y lo almacena
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
                            Descr = dr["Descr"].ToString(), //Extrae el valor y lo almacena
                        });
                    }
                    dr.Close();//Termina de leer
                    return Lis; //devuelve la lista
                }
                catch (Exception)//Si Ocurre una excepcion
                {
                    Lis = null;//Le asigna el valor null a la lista
                    return Lis;//Devuelve la lista
                }
            }
        }

        public bool Ingresar(EProv obj) //Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Prov", Con);//LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Tel", obj.Tel);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Email", obj.Email);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Giro", obj.Giro);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Descr", obj.Descr);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery();//Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);//Le asigna un valor
                }
                catch (Exception)//Si Ocurre una excepcion
                {
                    Respuesta = false;//Le asigna un valor
                }
            }
            return Respuesta;//Devuelve Respuesta
        }

        public bool Actualizar(EProv obj) //Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Act_Prov", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProv", obj.IdProv);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Tel", obj.Tel);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Email", obj.Email);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Giro", obj.Giro);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Descr", obj.Descr);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open(); //Abre Conexion
                    cmd.ExecuteNonQuery(); //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);//Le asigna un valor
                }
                catch (Exception)//Si Ocurre una excepcion
                {
                    Respuesta = false;//Le asigna un valor
                }
            }
            return Respuesta;//Devuelve Respuesta
        }

        public bool Eliminar(int Id) //Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Prov", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProv", Id);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery(); // Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //Le asigna un valor
                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false;//Le asigna un valor
                }
            }
            return Respuesta;//Devuelve Respuesta
        }
    }
}