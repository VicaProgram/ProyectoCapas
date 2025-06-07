using Datos;
using Entidad;
using System.Security.Cryptography;

namespace Negocio
{
    public class NLogin //Declara Clase
    {
        private DLogin Datos = new DLogin(); //Instancia clase

        public int IngSig(string Nombre, string Pass) //Ingresa al sistema
        {
            return DLogin.Instancia.IngSig(Nombre, Pass); //Llama metodo
        }

    }
}
