namespace PruebaBlazor.Models.Age.AdminRoles.AgeUsuarios
{
    public class AgeUsuariosSaveDAO
    {

        public AgeUsuariosPKDAO Id { get; set; }
        public string estado { get; set; }
        public string observacionEstado { get; set; }
        public int usuarioIngreso { get; set; }
        public int agePersonAgeLicencCodigo { get; set; }
        public long agePersonCodigo { get; set; }
        public int ageSucursAgeLicencCodigo { get; set; }
        public int ageSucursCodigo { get; set; }
        public int ageTipIdCodigo { get; set; }
        public string codigoExterno { get; set; }
        public string clave { get; set; }
        public string numeroIdentificacion { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string mailPrincipal { get; set; }
        public string telefonoCelular { get; set; }
        public string tipoUsuario { get; set; }
        public string primerIngreso { get; set; }
        public string tipoRegistro { get; set; }
        public string direccion { get; set; }
        public int ageLocaliCodigo { get; set; }
        public int ageLocaliAgeTipLoCodigo { get; set; }
        public int ageAgeTipLoAgePaisCodigo { get; set; }
        
    }
}
