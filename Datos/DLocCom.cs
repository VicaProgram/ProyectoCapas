using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DLocCom //Declara Clase
    {
        private Conexion Cn = new Conexion(); //Declara Variable

        public static DLocCom _instancia = null; //Declara Variable

        public static DLocCom Instancia //Declara Propiedad
        {
            get
            {
                if (_instancia == null) //Si es nulo
                {
                    _instancia = new DLocCom(); //Crea una nueva instancia
                }
                return _instancia; //Sino devuelve la instancia
            }
        }

        public List<ELocCom> Listar()  //Declara Metodo
        {
            List<ELocCom> Lis = new List<ELocCom>(); //Crea una lista
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) //Conexion DB
            {
                SqlCommand cmd = new SqlCommand("Bus_LCom", oConexion); //LLama al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                try //bloque try
                {
                    oConexion.Open(); //Abre Conexion
                    SqlDataReader dr = cmd.ExecuteReader(); //Ejecuta el procedimiento linea por linea
                    while (dr.Read()) //Mientras Lee
                    {
                        Lis.Add(new ELocCom() // Agrega un instancia a la lista
                        {
                            IdCom = Convert.ToInt32(dr["IdCom"].ToString()), //Extrae el valor y lo almacena
                            Nombre = dr["Nombre"].ToString(), //Extrae el valor y lo almacena
                            IdPro = Convert.ToInt32(dr["IdPro"].ToString()), //Extrae el valor y lo almacena
                            Pro = new ELocPro() { Nombre = dr["NombreProvincia"].ToString() }, //Extrae el valor y lo almacena
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
            DataTable dt = new DataTable(); //Crea objeto
            List<Parametro> parametros = new List<Parametro>(); //Crea lista
            try //bloque try
            {
                parametros.Add(new Parametro("@Id", Id)); //Parametro
                using (SqlConnection conexion = new SqlConnection(Conexion.Conex)) //Conexion db
                {
                    SqlCommand cmd = new SqlCommand("Fil_Id_LCom", conexion); //LLama al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    foreach (var parametro in parametros) //Loop de parametros
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor); //Añade un nuevo parámetro al objeto
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Saca los resultados de la consulta
                    {
                        da.Fill(dt); //llena el objeto
                    }
                }
                return dt; //Devuelve el objeto
            }
            catch (Exception ex) //Si Ocurre una excepcion
            {
                throw ex;//Devuelve excepcion
            }
        }

        public bool Ingresar(ELocCom obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Ing_LCom", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdPro", obj.IdPro); //Extrae el valor y lo almacena
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

        public bool Actualizar(ELocCom obj) //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Act_LCom", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom);  //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);  //Extrae el valor y lo almacena
                    cmd.Parameters.AddWithValue("IdPro", obj.IdPro);  //Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    Con.Open(); //Abre Conexion
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

        public bool Eliminar(int IdCom)  //Declara Metodo
        {
            bool Respuesta = true; //Declara Variable
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try //bloque try
                {
                    SqlCommand cmd = new SqlCommand("Eli_LCom", Con); //LLama al Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdCom", IdCom);//Extrae el valor y lo almacena
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //Parametro de salida
                    cmd.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    Con.Open(); //Abre Conexion
                    cmd.ExecuteNonQuery(); // Ejecuta el comando
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