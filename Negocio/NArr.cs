using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NArr
    {
        /* public List<EArr> Listar()
         {
             return DArr.Instancia.Listar();
         }*/

        public static Respuesta<bool> Ingresar(EArr obj)
        {
            bool Respuesta = false;
            Respuesta = DArr.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EArr obj)
        {
            bool Respuesta = false;
            Respuesta = DArr.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { estado = Respuesta };
        }

        /* public static Respuesta<bool> Eliminar(int Id)
         {
             bool Respuesta = false;
             Respuesta = DArr.Instancia.Eliminar(Id);
             return new Respuesta<bool>() { estado = Respuesta };
         }*/
    }
}
