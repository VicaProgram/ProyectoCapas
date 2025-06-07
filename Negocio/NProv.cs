using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NProv //Declara Clase
    {

        public List<EProv> Listar() //Devuelve una lista de objetos
        {
            return DProv.Instancia.Listar();  //LLama el metodo
        }

        public static Respuesta<bool> Ingresar(EProv obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DProv.Instancia.Ingresar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(EProv obj) //Actualiza un registro
        { 
            bool Respuesta = false; //Declara Variable
            Respuesta = DProv.Instancia.Actualizar(obj);  //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id) // Elimina un registro
        {
            bool Respuesta = false;//Declara Variable
            Respuesta = DProv.Instancia.Eliminar(Id); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta };//Devuelve Respuesta
        }
    }
}
