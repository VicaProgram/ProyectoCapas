using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Datos
{
    public class DLocReg //Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DLocReg _instancia = null; //Declara Variable

        public static DLocReg Instancia //Declara Propiedad
        {
            get
            {
                if (_instancia == null) //Si es nulo
                {
                    _instancia = new DLocReg(); //Crea una nueva instancia
                }
                return _instancia; //Sino devuelve la instancia
            }
        }

        public List<ELocReg> Listar()//Declara Metodo
        {
            List<ELocReg> Lis = new List<ELocReg>();//Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))//Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_LReg", oConexion);//LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                try//bloque try
                {
                    oConexion.Open();//Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader();//Ejecuta el procedimiento linea por linea
                    while (dr.Read()) //Mientras Lee
                    {
                        Lis.Add(new ELocReg() // Agrega un instancia a la lista
                        {
                            IdReg = Convert.ToInt32(dr["IdReg"]), //Extrae el valor y lo almacena
                            Nombre = dr["Nombre"].ToString(), //Extrae el valor y lo almacena
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

        public bool Ingresar(ELocReg obj) //Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try//bloque try
                {
                    SqlCommand cmd = new SqlCommand("Ing_LReg", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery();//Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);//Le asigna un valor
                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }

        public bool Actualizar(ELocReg obj)//Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try//bloque try
                {
                    SqlCommand cmd = new SqlCommand("Act_LReg", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdReg", obj.IdReg);//Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery(); //Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);//Le asigna un valor
                }
                catch (Exception) //Si Ocurre una excepcion
                {
                    Respuesta = false; //Le asigna un valor
                }
            }
            return Respuesta;//Devuelve Respuesta
        }

        public bool Eliminar(int Id)//Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try//bloque try
                {
                    SqlCommand cmd = new SqlCommand("Eli_LReg", Con);//LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdReg", Id);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery();// Ejecuta el comando
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);//Le asigna un valor
                }
                catch (Exception)//Si Ocurre una excepcion
                {
                    Respuesta = false;//Le asigna un valor
                }
            }
            return Respuesta; //Devuelve Respuesta
        }
    }
}