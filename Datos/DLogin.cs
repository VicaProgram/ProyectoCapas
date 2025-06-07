using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DLogin//Declara Clase
    {
        private Conexion Cn = new Conexion();//Declara Variable

        public static DLogin _instancia = null;//Declara Variable

        public static DLogin Instancia//Declara Propiedad
        {
            get
            {
                if (_instancia == null)//Si es nulo
                {
                    _instancia = new DLogin();//Crea una nueva instancia
                }
                return _instancia;//Sino devuelve la instancia
            }
        }

        public int IngSig(string Nombre, string Pass)//Declara Metodo
        {
            int Respuesta = 0; //Declara Variable

            using (SqlConnection connection = new SqlConnection(Conexion.Conex)) //Conexion db
            {
                try//bloque try
                {
                    SqlCommand command = new SqlCommand("IngSig", connection);//LLama al Procedimiento Almacenado
                    command.Parameters.AddWithValue("Nombre", Nombre);//Extrae el valor y lo almacena
                    command.Parameters.AddWithValue("Pass", Pass);//Extrae el valor y lo almacena
                    command.Parameters.Add("IdUsu", SqlDbType.Int).Direction = ParameterDirection.Output;//Parametro de salida
                    command.CommandType = CommandType.StoredProcedure; //Identifica que es un Procedimiento Almacenado
                    connection.Open();//Abre Conexion
                    command.ExecuteNonQuery();//Ejecuta el comando
                    Respuesta = Convert.ToInt32(command.Parameters["IdUsu"].Value);//Le asigna un valor

                }
                catch (Exception)//Si Ocurre una excepcion
                {
                    Respuesta = 0; //Le asigna un valor
                }
            }
            return Respuesta;//Devuelve Respuesta
        }
    }
}