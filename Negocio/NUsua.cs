using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsua
    {
        public static Respuesta<bool> Verificar(EUsua obj)
        {
            bool respuesta = DUsua.Instancia.Verificar(obj); return new Respuesta<bool>() { estado = respuesta, valor = respuesta ? "Inicio de sesión exitoso" : "Usuario o contraseña incorrectos" };
        }
    }
}
