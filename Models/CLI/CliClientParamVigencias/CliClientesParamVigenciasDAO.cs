using PruebaBlazor.Models.CLI.CliClient;
using Newtonsoft.Json;


namespace PruebaBlazor.Models.CLI.CliClientParamVigencias
{
    public class CliClientesParamVigenciasDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("id")]
        public CliClientesParamVigenciasPK Id { get; set; }

        [JsonProperty("observacion")]
        public string Observacion { get; set; }

    
        [JsonProperty("fechaDesde")]
        public DateTime FechaDesde { get; set; }

       
        [JsonProperty("fechaHasta")]
        public DateTime FechaHasta { get; set; }

      
        [JsonProperty("valorParametro")]
        public string ValorParametro { get; set; }

        [JsonProperty("cliente")]
        public CliClienteDAO Cliente { get; set; }

    }
}
