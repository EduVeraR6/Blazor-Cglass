

using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeAplicaciones
{
    public class AgeAplicacionesDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; } = null!;

        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("codigoExterno")]
        public string CodigoExterno { get; set; } = null!;

        [JsonProperty("descripcion")]
        public string? Descripcion { get; set; }

        [JsonProperty("inicioSecuTrxCe")]
        public long InicioSecuenciaTransaccionesCE { get; set; }

        [JsonProperty("incrementoSecuTrxCe")]
        public int IncrementoSecuenciaTransaccionesCE { get; set; }

        [JsonProperty("valorActualSecuTrxCe")]
        public long ValorActualSecuenciaTransaccionesCE { get; set; }

        [JsonProperty("ciclicaSecuTrxCe")]
        public string? CiclicaSecuenciaTransaccionesCE { get; set; }

        [JsonProperty("inicioSecuTrxCi")]
        public long InicioSecuenciaTransaccionesCI { get; set; }

        [JsonProperty("valorActualSecuTrxCi")]
        public long ValorActualSecuenciaTransaccionesCI { get; set; }

        [JsonProperty("ciclicaSecuTrxCi")]
        public string? CiclicaSecuenciaTransaccionesCI { get; set; }

        [JsonProperty("ordenInstalacion")]
        public int OrdenInstalacion { get; set; }

    }
}
