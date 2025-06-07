using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DLocPro //Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DLocPro _instancia = null; //Declara Variable

        public static DLocPro Instancia //Declara Propiedad
        {
            get
            {
                if (_instancia == null) //Si es nulo
                {
                    _instancia = new DLocPro(); //Crea una nueva instancia
                }
                return _instancia; //Sino devuelve la instancia
            }
        }

        public List<ELocPro> Listar() //Declara Metodo
        {
            List<ELocPro> Lis = new List<ELocPro>(); //Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_LPro", oConexion); //LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                try //bloque try
                {
                    oConexion.Open(); //Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el procedimiento linea por linea
                    while (dr.Read())  //Mientras Lee
                    {
                        Lis.Add(new ELocPro() // Agrega un instancia a la lista
                        {
                            IdPro = Convert.ToInt32(dr["IdPro"].ToString()), //Extrae el valor y lo almacena
                            Nombre = dr["Nombre"].ToString(), //Extrae el valor y lo almacena
                            IdReg = Convert.ToInt32(dr["IdReg"].ToString()), //Extrae el valor y lo almacena
                            Reg = new ELocReg() { Nombre = dr["NombreRegion"].ToString() }, //Extrae el valor y lo almacena
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

        public DataTable Filtrar(int Id) //Declara Metodo
        {
            DataTable dt = new DataTable();  //Crea objeto
            List<Parametro> parametros = new List<Parametro>(); //Crea lista
            try //bloque try
            { 
                parametros.Add(new Parametro("@Id", Id)); //Parametro
                using (SqlConnection conexion = new SqlConnection(Conexion.Conex))  //Conexion db
                {
                    SqlCommand cmd = new SqlCommand("Fil_Id_LPro", conexion); //LLama al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    foreach (var parametro in parametros) //Loop de parametros
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);  //Añade un nuevo parámetro al objeto
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Saca los resultados de la consulta
                    { 
                        da.Fill(dt);  //llena el objeto
                    }
                }
                return dt; //Devuelve el objeto
            }
            catch (Exception ex)  //Si Ocurre una excepcion
            {
                throw ex; //Devuelve excepcion
            }
        }

        public bool Ingresar(ELocPro obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Ing_LPro", Con);  //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdReg", obj.IdReg); //Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    Con.Open(); //Abre Conexion
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

        public bool Actualizar(ELocPro obj)//Declara Metodo
        {
            bool Respuesta = true;//Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))//Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Act_LPro", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdPro", obj.IdPro);  //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);  //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdReg", obj.IdReg);  //Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;  //Identifica que es un Procedimiento Almacenado
                    Con.Open(); //Abre Conexion
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

        public bool Eliminar(int IdPro) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try//bloque try
                {
                    SqlCommand cmd = new SqlCommand("Eli_LPro", Con);  //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdPro", IdPro); //Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure;//Identifica que es un Procedimiento Almacenado
                    Con.Open();//Abre Conexion
                    cmd.ExecuteNonQuery();// Ejecuta el comando
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