using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NArr_VUn
    {
        /* public List<EArr> Listar()
 {
     return DArr.Instancia.Listar();
 }*/

        public static Respuesta<bool> Ingresar(EArr_VUn obj)
        {
            bool Respuesta = false;
            Respuesta = DArr_VUn.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { estado = Respuesta };
        }

        /*public static Respuesta<bool> Actualizar(EArr_VUn obj)
        {
            bool Respuesta = false;
            Respuesta = DArr_VUn.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { estado = Respuesta };
        }*/

        /* public static Respuesta<bool> Eliminar(int Id)
         {
             bool Respuesta = false;
             Respuesta = DArr.Instancia.Eliminar(Id);
             return new Respuesta<bool>() { estado = Respuesta };
         }*/
        public int ObtenerUltimoId() //Busca un registro
        {
            return DArr_VUn.Instancia.ObtenerUltimoId(); //LLama el metodo
        }
    }
}
