using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class UsuarioFormulario
    {
        [Required(ErrorMessage = "La dirección de correo es obligatoria.")]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [PasswordPropertyText]
        public string Password { get; set; }

    }
}
