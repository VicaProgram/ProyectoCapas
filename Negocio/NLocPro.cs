using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NLocPro //Declara Clase
    {

        public List<ELocPro> Listar() //Devuelve una lista de objetos
        {
            return DLocPro.Instancia.Listar();//LLama el metodo
        }

        public DataTable Filtrar(int IdPro)//Busca un registro
        {
            return DLocPro.Instancia.Filtrar(IdPro);//LLama el metodo
        }

        public static Respuesta<bool> Ingresar(ELocPro obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocPro.Instancia.Ingresar(obj);//LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta };//Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(ELocPro obj) //Actualiza un registro
        {
            bool Respuesta = false;//Declara Variable
            Respuesta = DLocPro.Instancia.Actualizar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta };//Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id)// Elimina un registro
        {
            bool Respuesta = false;//Declara Variable
            Respuesta = DLocPro.Instancia.Eliminar(Id);//LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta };//Devuelve Respuesta
        }

    }
}