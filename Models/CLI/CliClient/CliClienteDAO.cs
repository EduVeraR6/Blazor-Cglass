using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using PruebaBlazor.Models.CLI.CliTiposCliente;

namespace PruebaBlazor.Models.CLI.CliClient
{
    public class CliClienteDAO
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("id")]
        public CliClientesPK Id { get; set; }

        [JsonProperty("cliTIpClCodigo")]
        public long CliTIpClCodigo { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("nombreCorto")]
        public string NombreCorto { get; set; }

        [JsonProperty("telefonoCelular")]
        public string TelefonoCelular { get; set; }

        [JsonProperty("correoElectronico")]
        public string CorreoElectronico { get; set; }

        [JsonProperty("agePersonAgeLicencCodigo")]
        public int AgePersonAgeLicencCodigo { get; set; }

        [JsonProperty("agePersonCodigo")]
        public long AgePersonCodigo { get; set; }

        [JsonProperty("ageClaCoCodigo")]
        public int AgeClaCoCodigo { get; set; }

        [JsonProperty("ageTipIdCodigo")]
        public int AgeTipIdCodigo { get; set; }

        [JsonProperty("cliTipClAgeLicencCodigo")]
        public int CliTipClAgeLicencCodigo { get; set; }

        [JsonProperty("agageSegmenAgeLicencCodigo")]
        public int AgageSegmenAgeLicencCodigo { get; set; }

        [JsonProperty("ageSubSeAgeSegmenCodigo")]
        public int AgeSubSeAgeSegmenCodigo { get; set; }

        [JsonProperty("ageSubSeCodigo")]
        public int AgeSubSeCodigo { get; set; }

        [JsonProperty("informacionAdicional")]
        public string InformacionAdicional { get; set; }

        [JsonProperty("ageUsuariCodigo")]
        public long AgeUsuariCodigo { get; set; }

        [JsonProperty("ageUsuariAgeLicencCodigo")]
        public int AgeUsuariAgeLicencCodigo { get; set; }

        [JsonProperty("latitudActual")]
        public string LatitudActual { get; set; }

        [JsonProperty("longitudActual")]
        public string LongitudActual { get; set; }

        [JsonProperty("ageAgeTipLoAgePaisCodigo")]
        public int AgeAgeTipLoAgePaisCodigo { get; set; }

        [JsonProperty("ageLocaliAgeTipLoCodigo")]
        public int AgeLocaliAgeTipLoCodigo { get; set; }

        [JsonProperty("ageLocaliCodigo")]
        public int AgeLocaliCodigo { get; set; }

        [JsonProperty("direccionPrincipal")]
        public string DireccionPrincipal { get; set; }

        [JsonProperty("estadoCivil")]
        public string EstadoCivil { get; set; }

        [JsonProperty("nombreComercial")]
        public string NombreComercial { get; set; }

        [JsonProperty("razonSocial")]
        public string RazonSocial { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("telefonoOpcional")]
        public string TelefonoOpcional { get; set; }

        [JsonProperty("tipoCliente")]
        public CliTiposClienteDAO TipoCliente { get; set; }

    }
}
