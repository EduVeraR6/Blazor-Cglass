using PruebaBlazor.Models.AGE.AgeCamposGenerales;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeTransacciones
{
    public class AgeTransaccionesSaveDAO : AgeCamposGeneralesDAO
    {
        public AgeTransaccionesPKDAO Id { get; set; }
        public int CodigoExterno { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Transaccion { get; set; }
        public short OrdenPresentacion { get; set; }
        public string TipoTransaccion { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public int? AgeTransaAgeAplicaCodigo { get; set; }
        public int? AgeTransaCodigo { get; set; }
        public string? Opcion { get; set; }
        public short Nivel { get; set; }
        public string? Url { get; set; }
        public string? Parametros { get; set; }
     
    }
}
