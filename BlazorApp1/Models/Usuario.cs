using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Usuario
    {
        /*
        [{
        "NOMBREUSUARIO":"CT CONSER JAIME MOLA",
        "PERFIL":"CONTADOR",
        "OBSERVACION":"INGRESO EXITOSO",
        "CODIGOPERFIL":81,"ESTADO":"A",
        "COMPANIA":17,
        "Emisor":17,
        "Cargo":81,
        "NOMBREEMISOR":"CONSERVATORIO JAIME MOLA",
        "NOMBRECOMPANIA":"CONSERVATORIO JAIME MOLA",
        "USUARIOCLIENTE":"1791787641001",
        "RucUsuario":"1791787641001"
        }]
        */
        public string NombreUsuario { get; set; }
        public string Perfil { get; set; }
        public string Observacion { get; set; }
        public int CodigoPerfil { get; set; }
        public int Compania { get; set; }
        public int Emisor { get; set; }
        public int Cargo { get; set; }
        //public string Estado { get; set; }
        public string NombreEmisor { get; set; }
        public string NombreCompania { get; set; }
        public string UsuarioCliente { get; set; }
        public string RucUsuario { get; set; }

        public Usuario() {}
    }

}
