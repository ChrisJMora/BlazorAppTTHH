using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class UsuarioFormulario
    {
        [Required(ErrorMessage = "El código de usuario es incorrecto.")]
        [MinLength(4, ErrorMessage = "El código se conforma de 4 dígitos")]
        [MaxLength(4, ErrorMessage = "El código se conforma de 4 dígitos")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [PasswordPropertyText]
        public string Password { get; set; }

    }
}
