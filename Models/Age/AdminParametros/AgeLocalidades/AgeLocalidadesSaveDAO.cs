using PruebaBlazor.Models.AGE.AgeCamposGenerales;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades
{
    public class AgeLocalidadesSaveDAO : AgeCamposGeneralesDAO
    {
        [JsonProperty("id")]
        public AgeLocalidadesPKDAO Id { get; set; }

        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int? AgeAgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("ageIdiomaCodigo")]
        public int? AgeIdiomaCodigo { get; set; }

        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int? AgeLocaliAgeTipLoCodigo { get; set; }

        [JsonProperty("ageLocaliCodigo")]
        public int? AgeLocaliCodigo { get; set; }

        [JsonProperty("ageMonedaCodigo")]
        public int? AgeMonedaCodigo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;

        [JsonProperty("latitudCentro")]
        public decimal? LatitudCentro { get; set; }

        [JsonProperty("longitudCentro")]
        public decimal? LongitudCentro { get; set; }

        [JsonProperty("poligono")]
        public List<List<List<decimal>>>? Poligono { get; set; }

    }
}
