
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaSecu
{
    public class UpdateAgeLicenciatarioAplicaSecuRequest
    {
        public AgeLicenciatarioAplicaSecuPKDAO Id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "estado")]
        
        public string? Estado { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usuarioModificacion")]

        public int? UsuarioModificacion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "descripcion")]

        public string? Descripcion { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valorInicial")]

        public long ValorInicial { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "incrementaEn")]


        public int IncrementaEn { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usuarioIngreso")]

        public int UsuarioIngreso { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ciclica")]
        public string? Ciclica { get; set; }

        public UpdateAgeLicenciatarioAplicaSecuRequest(AgeLicenciatarioAplicaSecuPKDAO id)
        {
            Id = id;
            AsignarUsuarioModificacionDesdeId();
        }


        private void AsignarUsuarioModificacionDesdeId()
        {
            if (Id != null)
            {
                UsuarioModificacion = Id.ageLicencCodigo;
            }

        }

    }
}
