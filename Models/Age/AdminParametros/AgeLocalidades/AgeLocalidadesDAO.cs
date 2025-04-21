using PruebaBlazor.Models.Age.AdminParametros.AgeIdiomas;
using PruebaBlazor.Models.Age.AdminParametros.AgeMonedas;
using PruebaBlazor.Models.Age.AdminParametros.AgePaises;
using PruebaBlazor.Models.Age.AdminParametros.AgeTiposLocalidades;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLocalidades
{
    public class AgeLocalidadesDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

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

        [JsonProperty("tiposLocalidade")]
        public AgeTiposLocalidadeDAO? TiposLocalidade { get; set; }

        [JsonProperty("moneda")]
        public AgeMonedasDAO? Moneda { get; set; }

        [JsonProperty("idioma")]
        public AgeIdiomasDAO? Idioma { get; set; }

        [JsonProperty("localidad")]
        public AgeLocalidadesDAO? Localidad { get; set; }

        [JsonProperty("paises")]
        public AgePaisesDAO? Paises { get; set; }
    }
}
