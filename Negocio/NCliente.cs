using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NCliente //Declara Clase
    {
        public List<ECliente> Listar() //Devuelve una lista de objetos
        {
            return DCliente.Instancia.Listar(); //LLama el metodo
        }

        public bool Buscar(ECliente obj) //Busca un registro
        {
            return DCliente.Instancia.Buscar(obj); //LLama el metodo
        }

        public static Respuesta<bool> Ingresar(ECliente obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DCliente.Instancia.Ingresar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(ECliente obj) //Actualiza un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DCliente.Instancia.Actualizar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id) // Elimina un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DCliente.Instancia.Eliminar(Id); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }
        public int ObtenerUltimoId() //Busca un registro
        { 
            return DCliente.Instancia.ObtenerUltimoId(); //LLama el metodo
        }
    }
}