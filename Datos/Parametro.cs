namespace Datos
{
    public class Parametro
    {
        public string Nombre { get; set; } //Obtiene o establece el nombre del parámetro
        public object Valor { get; set; } //Obtiene o establece el nombre del parámetro

        public Parametro(string nombre, object valor) // Inicializa una nueva instancia de la clase Parametro.
        {
            Nombre = nombre; //Le asigna un valor
            Valor = valor; //Le asigna un valor
        }
    }
}