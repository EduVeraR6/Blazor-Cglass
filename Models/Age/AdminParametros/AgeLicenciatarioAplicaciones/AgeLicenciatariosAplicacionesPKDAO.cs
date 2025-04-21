using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PruebaBlazor.Models.Age.AdminParametros.AgeLicenciatarioAplicaciones
{
    public class AgeLicenciatariosAplicacionesPKDAO
    {
        [JsonProperty("ageLicencCodigo")]
        public int AgeLicencCodigo { get; set; }

        [JsonProperty("ageAplicaCodigo")]
        public int AgeAplicaCodigo { get; set; }
    }
}
