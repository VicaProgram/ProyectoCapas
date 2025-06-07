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
    public class DArr
    {
        private Conexion Cn = new Conexion();

        public static DArr _instancia = null;

        public static DArr Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArr();
                }
                return _instancia;
            }
        }

        public bool Ingresar(EArr obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Arr", Con);
                    cmd.Parameters.AddWithValue("IdP_Cli", obj.IdP_Cli);
                    cmd.Parameters.AddWithValue("Fech", obj.Fech);
                    cmd.Parameters.AddWithValue("IdAPro", obj.IdAPro);
                    cmd.Parameters.AddWithValue("IdADet", obj.IdADet);
                    cmd.Parameters.AddWithValue("IdAVUn", obj.IdAVUn);
                    cmd.Parameters.AddWithValue("SubTo", obj.SubTotal);
                    cmd.Parameters.AddWithValue("Descuento", obj.DescuentoTotal);
                    cmd.Parameters.AddWithValue("IVA", obj.IVA_Total);
                    cmd.Parameters.AddWithValue("Total", obj.TotalFinal);
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

        public bool Actualizar(EArr obj)
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Arr", Con);
                    cmd.Parameters.AddWithValue("IdArr", obj.IdArr);
                    cmd.Parameters.AddWithValue("IdP_Cli", obj.IdP_Cli);
                    cmd.Parameters.AddWithValue("Fech", obj.Fech);
                    cmd.Parameters.AddWithValue("SubTo", obj.SubTotal);
                    cmd.Parameters.AddWithValue("Descuento", obj.DescuentoTotal);
                    cmd.Parameters.AddWithValue("IVA", obj.IVA_Total);
                    cmd.Parameters.AddWithValue("Total", obj.TotalFinal);
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
    }
}
