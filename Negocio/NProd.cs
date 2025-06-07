using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProd//Declara Clase
    {
        public List<EProd> Listar() //Devuelve una lista de objetos
        {
            return DProd.Instancia.Listar(); //LLama el metodo
        }
        public static Respuesta<bool> Ingresar(EProd obj) //Ingresa un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DProd.Instancia.Ingresar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Actualizar(EProd obj) //Actualiza un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DProd.Instancia.Actualizar(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }
        public static Respuesta<bool> Actualizar2(EProd obj) //Actualiza un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DProd.Instancia.Actualizar2(obj); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }

        public static Respuesta<bool> Eliminar(int Id) // Elimina un registro
        {
            bool Respuesta = false; //Declara Variable
            Respuesta = DProd.Instancia.Eliminar(Id); //LLama el metodo
            return new Respuesta<bool>() { estado = Respuesta }; //Devuelve Respuesta
        }
    }
}
