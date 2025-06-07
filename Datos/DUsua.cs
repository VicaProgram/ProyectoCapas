using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Datos
{
    public class DUsua
    {
        private Conexion Cn = new Conexion();

        public static DUsua _instancia = null;

        public static DUsua Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DUsua();
                }
                return _instancia;
            }
        }

        public List<EUsua> Listar()
        {
            List<EUsua> Lis = new List<EUsua>();
            using (SqlConnection con = new SqlConnection(Conexion.Conex))
            {
                SqlCommand cmd = new SqlCommand("Bus_Usua", con);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new EUsua()
                        {
                            IdUsu = Convert.ToInt32(dr["IdUsu"]),
                            Nombre = dr["Nombre"].ToString(),
                            Pass = dr["Pass"].ToString(),
                        });
                    }
                    dr.Close();
                    return Lis;
                }
                catch (Exception)
                {
                    Lis = null;
                    return Lis;
                }
            }
        }
        public bool Insertar(EUsua obj)
        {
            bool respuesta = false;
            using (SqlConnection con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Usua", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Pass", obj.Pass);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Actualizar(EUsua obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Usua", Con);
                    cmd.Parameters.AddWithValue("IdUsu", obj.IdUsu);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Pass", obj.Pass);
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
        public bool Actualizar2(EUsua obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Usua2", Con);
                    cmd.Parameters.AddWithValue("IdUsu", obj.IdUsu);
                    cmd.Parameters.AddWithValue("Pass", obj.Pass);
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
        public bool Verificar(EUsua obj)
        {
            bool respuesta = false;
            using (SqlConnection con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("IngSis", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Pass", obj.Pass);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        respuesta = reader.GetInt32(0) == 1;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (log, re-throw, etc.)
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}