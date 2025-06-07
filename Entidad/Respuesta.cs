namespace Entidad
{
    public class Respuesta<T>
    {
        public bool estado { get; set; } //Obtiene o establece el estado
        public string valor { get; set; } //Obtiene o establece el texto
        public T objeto { get; set; } //Obtiene o establece el objeto
    }
}
