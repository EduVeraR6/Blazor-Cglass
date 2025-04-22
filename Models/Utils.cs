namespace PruebaBlazor.Models
{
    public enum OperacionEstado
    {
        Ninguna,
        Creando,
        Editando
    }

    public class SelectOption
    {
        public string Value { get; set; }
        public string Label { get; set; }
    }
}
