using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatParamVigencias
{
    public class AgeLicenciatParamVigenciasPKDAO
    {

        [JsonProperty("ageLicencCodigo")]
        public int AgeLicencCodigo { get; set; }

        [JsonProperty("ageParGeCodigo")]

        public int AgeParGeCodigo { get; set; }

        [JsonProperty("codigo")]

        public long Codigo { get; set; }
    }
}
