using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NLocCom //Declara Clase
    {

        public List<ELocCom> Listar() //Devuelve una lista de objetos
        {
            return DLocCom.Instancia.Listar(); //LLama el metodo
        }

        public DataTable Filtrar(int IdCom) //Busca un registro
        {
            return DLocCom.Instancia.Filtrar(IdCom); //LLama el metodo
        }

        public static Respuesta<bool> Ingresar(ELocCom obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocCom.Instancia.Ingresar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(ELocCom obj) //Actualiza un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocCom.Instancia.Actualizar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id) // Elimina un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocCom.Instancia.Eliminar(Id); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }
    }
}