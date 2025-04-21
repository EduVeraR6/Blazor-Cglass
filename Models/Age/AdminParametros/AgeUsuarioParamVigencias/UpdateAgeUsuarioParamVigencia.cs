using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeUsuarioParamVigencias
{
    public class UpdateAgeUsuarioParamVigencia
    {
        public AgeUsuarioParamVigenciaPKDAO id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string estado { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long usuarioIngreso { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long usuarioModificacion { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string observacion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? fechaDesde { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? fechaHasta { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string valorParametro { get; set; }
    }
}
