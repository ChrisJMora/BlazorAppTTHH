<<<<<<< HEAD
﻿namespace BlazorApp1.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Perfil { get; set; }
        public string Observacion { get; set; }
        public int CodigoPerfil { get; set; }
        public string Estado { get; set; }
        public int Compania { get; set; }
        public int Emisor { get; set; }
        public int Cargo { get; set; }
        public string NombreEmisor { get; set; }
        public string NombreCompania { get; set; }
        public string UsuarioCliente { get; set; }
        public string RucUsuario { get; set; }
    }

=======
﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "La dirección de correo es obligatoria.")]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
>>>>>>> b75ce1a1b6af9812190ff65d525c924f9655986f
}
