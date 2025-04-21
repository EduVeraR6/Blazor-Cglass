using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeAplicaciones
{
    public class UpdateAgeAplicacionesRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? estado { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? usuarioIngreso { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long usuarioModificacion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int codigo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? descripcion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? inicioSecuTrxCe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? incrementoSecuTrxCe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? valorActualSecuTrxCE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? ciclicaSecuTrxCe { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? inicioSecuTrxCi { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public long? valorActualSecuTrxCi { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? ciclicaSecuTrxCi { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? ordenInstalacion { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string? codigoExterno { get; set; }
    }

}
