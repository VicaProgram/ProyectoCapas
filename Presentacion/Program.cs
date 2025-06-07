using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arbol de proyecto
namespace Presentacion
{
    internal static class Program //Declara clase
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() //Declara metodo
        {
            Application.EnableVisualStyles(); // Activa estilos visuales para la aplicación
            Application.SetCompatibleTextRenderingDefault(false);// Establece la renderización de texto a la predeterminada
            Application.Run(new Menu());// Inicia la aplicación con el formulario
        }
    }
}
