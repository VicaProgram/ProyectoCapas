using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NLocReg //Declara Clase
    {
        public List<ELocReg> Listar() //Devuelve una lista de objetos
        {
            return DLocReg.Instancia.Listar();  //LLama el metodo
        }

        public static Respuesta<bool> Ingresar(ELocReg obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocReg.Instancia.Ingresar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(ELocReg obj) //Actualiza un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocReg.Instancia.Actualizar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id) // Elimina un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DLocReg.Instancia.Eliminar(Id); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }
    }
}