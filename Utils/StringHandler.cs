namespace PruebaBlazor.Utils
{
    public class StringHandler
    {
        internal const string CLIENTE1 = "Backend";


        //PRINCIPAL
        const string BASE = "/principal";

        //MODULO
        const string AGE = "/age";
        const string CLI = "/cli";

        //SUBMODULO
        const string ADMIN_PARAMETROS = "/admin-Param";
        const string ADMIN_ROLES = "/admin-Roles";


        //ENTIDADES
        const string MONEDA = "/monedas";
        const string APLICACIONES = "/aplicaciones";
        const string CLASES_CONSTRIBUYENTES = "/clases-Contribuyentes";
        const string DIAS_FERIADOS = "/dias-feriados";
        const string DIRECCIONES = "/direcciones";
        const string FERIADO_PAISES = "/feriados-Paises";
        const string FERIADO_EXCEPCIONES = "/feriados-Excepciones";
        const string FERIADO_LOCALIDADES = "/feriados-Localidades";
        const string FIRMAS_DIGITALES = "/firmas-digitales";
        const string FORMAS_PAGOS = "/formasPago";
        const string FORMAS_PAGOS_INST_FINA = "/formas-Pagos-Instina";
        const string IDIOMAS_PAISES = "/idiomas-Paises";
        const string IDIOMAS = "/idiomas";
        const string INSTITUCIONES_FINANCIERAS = "/institucionesFinancieras";
        const string LICENCIATARIO_APLICACIONES = "/licenciatarios-Aplicaciones";
        const string LICENCIATARIO_APLICA_SECU = "/SecuencialesLas";
        const string LOCALIDADES = "/localidades";
        const string LOG_ERRORES = "/log-Errores";
        const string MENSAJES = "/mensajes";
        const string MENSAJES_IDIOMAS = "/mensajesIdiomas";
        const string MONEDA_COTIZACIONES = "/cotizacion-Monedas";
        const string PAISES = "/paises";
        const string PARAM_GENERAL = "/parametro-General";
        const string PARAM_GENERAL_USUARIO = "/parametro-General-Usuario";
        const string PARAM_GENERAL_VIGENCIAS = "/parametro-general-vigencia";
        const string PERSONAS = "/personas";
        const string PUNTO_EMISION = "/punto-Emision";
        const string SUB_APLICACIONES = "/subAplicaciones";
        const string SUCURSALES = "/sucursales";
        const string TIPO_DIRECCIONES = "/tipos-Direcciones";
        const string TIPO_LOCALIDADES = "/tipos-Localidades";
        const string TIPO_SUCURSALES = "/tipos-Sucursales";
        const string TRANSACCIONES = "/transacciones";
        const string USUARIO_PARAM_VIGENCIAS = "/UsuarioVigente";
        const string USUARIO_PUNTO_EMISION = "/usuario-Punto-Emision";
        const string PARAM_GENERAL_LICENCIATARIO = "/parametro-General-Licenciatario";
        const string PERFILES = "/perfiles";
        const string PERFILES_TRANSACCIONES = "/perfiles-Transacciones";
        const string USUARIOS = "/usuarios";
        const string USUARIOS_PERFILES = "/usuarios-Perfiles";
        const string AUTHENTICATE = "/";




        //ENTIDADES CLI 

        const string TIPOS_CLIENTE = "/tipos-clientes";
        const string CLIENTES_PARAM_VIGENCIAS = "/clientes-parametros-vigencias";
        const string CONTACTOS = "/forma-contacto";
        const string CLIENTES = "/clientes";


        //PATHS
        internal const string PATH_MONEDA = $"{BASE}{AGE}{ADMIN_PARAMETROS}{MONEDA}";
        internal const string PATH_IDIOMA = $"{BASE}{AGE}{ADMIN_PARAMETROS}{IDIOMAS}";
        internal const string PATH_PAISES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PAISES}";
        internal const string PATH_LOCALIDADES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{LOCALIDADES}";
        internal const string PATH_FIRMAS_DIGITALES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FIRMAS_DIGITALES}";
        internal const string PATH_TIPOS_LOCALIDADES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{TIPO_LOCALIDADES}";
        internal const string PATH_PARAM_GENERAL_USUARIO = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PARAM_GENERAL_USUARIO}";
        internal const string PATH_PARAM_GENERAL_lICENCIATARIO = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PARAM_GENERAL_LICENCIATARIO}";
        internal const string PATH_PARAM_GENERAL_VIGENCIAS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PARAM_GENERAL_VIGENCIAS}";//
        internal const string PATH_APLICACIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{APLICACIONES}";
        internal const string PATH_CLASES_CONSTRIBUYENTES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{CLASES_CONSTRIBUYENTES}";
        internal const string PATH_DIAS_FERIADOS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{DIAS_FERIADOS}";
        internal const string PATH_DIRECCIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{DIRECCIONES}";
        internal const string PATH_FERIADO_PAISES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FERIADO_PAISES}";
        internal const string PATH_FERIADO_EXCEPCIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FERIADO_EXCEPCIONES}";
        internal const string PATH_FERIADO_LOCALIDADES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FERIADO_LOCALIDADES}";
        internal const string PATH_FORMAS_PAGOS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FORMAS_PAGOS}";
        internal const string PATH_FORMAS_PAGOS_INST_FINA = $"{BASE}{AGE}{ADMIN_PARAMETROS}{FORMAS_PAGOS_INST_FINA}";
        internal const string PATH_IDIOMAS_PAISES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{IDIOMAS_PAISES}";
        internal const string PATH_INSTITUCIONES_FINANCIERAS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{INSTITUCIONES_FINANCIERAS}";
        internal const string PATH_LICENCIATARIO_APLICACIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{LICENCIATARIO_APLICACIONES}";
        internal const string PATH_LICENCIATARIO_APLICA_SECU = $"{BASE}{AGE}{ADMIN_PARAMETROS}{LICENCIATARIO_APLICA_SECU}";
        internal const string PATH_LOG_ERRORES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{LOG_ERRORES}";
        internal const string PATH_MENSAJES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{MENSAJES}";
        internal const string PATH_MENSAJES_IDIOMAS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{MENSAJES_IDIOMAS}";
        internal const string PATH_MONEDA_COTIZACIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{MONEDA_COTIZACIONES}";
        internal const string PATH_PARAM_GENERAL = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PARAM_GENERAL}";
        internal const string PATH_PERSONAS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PERSONAS}";
        internal const string PATH_PUNTO_EMISION = $"{BASE}{AGE}{ADMIN_PARAMETROS}{PUNTO_EMISION}";
        internal const string PATH_SUB_APLICACIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{SUB_APLICACIONES}";
        internal const string PATH_SUCURSALES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{SUCURSALES}";
        internal const string PATH_TIPOS_DIRECCIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{TIPO_DIRECCIONES}";
        internal const string PATH_TIPOS_SUCURSALES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{TIPO_SUCURSALES}";
        internal const string PATH_TRANSACCIONES = $"{BASE}{AGE}{ADMIN_PARAMETROS}{TRANSACCIONES}";
        internal const string PATH_USUARIO_PARAM_VIGENCIAS = $"{BASE}{AGE}{ADMIN_PARAMETROS}{USUARIO_PARAM_VIGENCIAS}";
        internal const string PATH_USUARIO_PUNTO_EMISION = $"{BASE}{AGE}{ADMIN_PARAMETROS}{USUARIO_PUNTO_EMISION}";



        internal const string PATH_USUARIOS_PERFILES = $"{BASE}{AGE}{ADMIN_ROLES}{USUARIOS_PERFILES}";
        internal const string PATH_PERFILES_TRANSACCIONES = $"{BASE}{AGE}{ADMIN_ROLES}{PERFILES_TRANSACCIONES}";
        internal const string PATH_PERFILES = $"{BASE}{AGE}{ADMIN_ROLES}{PERFILES}";
        internal const string PATH_USUARIOS = $"{BASE}{AGE}{ADMIN_ROLES}{USUARIOS}";
        internal const string PATH_AUTHENTICATE = $"{BASE}{AGE}{ADMIN_ROLES}{AUTHENTICATE}";


        //PATHS CLI 
        internal const string PATH_TIPOS_CLIENTES =  $"{BASE}{CLI}{TIPOS_CLIENTE}";
        internal const string PATH_CLIENTES_PARAM_VIGENCIAS = $"{BASE}{CLI}{CLIENTES_PARAM_VIGENCIAS}";
        internal const string PATH_CONTACTOS = $"{BASE}{CLI}{CONTACTOS}";
        internal const string PATH_CLIENTES = $"{BASE}{CLI}{CLIENTES}";


    }
}
