using PruebaBlazor.Models.Age.AdminParametros.AgeAplicaciones;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTransacciones
{
    public class AgeTransaccionesDAO
    {
        public AgeTransaccionesPKDAO Id { get; set; }
        public int CodigoExterno { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Transaccion { get; set; }
        public short? OrdenPresentacion { get; set; }
        public string TipoTransaccion { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public int? AgeTransaAgeAplicaCodigo { get; set; }
        public int? AgeTransaCodigo { get; set; }
        public string? Opcion { get; set; }
        public short? Nivel { get; set; }
        public string? Url { get; set; }
        public string? Parametros { get; set; }
        public string Estado { get; set; } = null!;
        public List<AgeTransaccionesDAO>? AgeTransaccioneList { get; set; }
        public AgeAplicacionesDAO Aplicaciones { get; set; }
    }
}
