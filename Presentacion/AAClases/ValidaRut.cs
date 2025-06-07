using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Arbol de proyecto
namespace Presentacion.AAClases
{
    public class ValidaRut //Declara Clase
    {
        public string formatoRut(string rut) // Declara metodo
        {
            int cont = 0; //Declara variable
            string format;//Declara variable
            rut = rut.Replace(".", "");//Borra .
            rut = rut.Replace("-", "");//Borra -
            format = "-" + rut.Substring(rut.Length - 1);//Resta 1 a la cadena
            for (int i = rut.Length - 2; i >= 0; i--) //Itera desde atra hacia delante
            {
                format = rut.Substring(i, 1) + format; //Pasa la cadena a format
                cont++; //Incrementa el contador
                if (cont == 3 && i != 0)  //Verifica si el contador llego a 3 y i diferente de 0
                {
                    format = "." + format; //Inserta un . al inicio
                    cont = 0; //Resetea contador
                }
            }
            return format; //Devuelve format
        }

        public bool validarRut(string rut) // Declara metodo
        {
            bool validacion = false; //Declara variable
            try //Bloque try
            {
                rut = rut.ToUpper(); // Convierte el input a mayúsculas
                rut = rut.Replace(".", "");// Elimina los puntos
                rut = rut.Replace("-", "");// Elimina los guiones
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));// Analiza la parte numérica
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1)); // Extrae el dígito verificador
                int m = 0, s = 1;// Inicializa el multiplicador y la suma
                for (; rutAux != 0; rutAux /= 10)// Itera sobre cada dígito
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11; // Calcula la suma para la verificación
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))// Comprueba si el dígito verificador coincide
                {
                    validacion = true;// Establece la validación como verdadera si coincide
                }
            }
            catch (Exception)
            {
            }
            return validacion;// Devuelve el resultado de la validación
        }
    }
}
