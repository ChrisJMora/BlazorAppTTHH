namespace BlazorApp1.Models.FlyweightUsuario;

public class Usuario
{
    // Contiene toda la información personal del usuario. [Datos extrínsicos]
    public string NombreUsuario {
        get => _nombreUsuario ?? "default"; 
        set { _nombreUsuario = value ?? "default"; }
        }
    public string UsuarioCliente {
        get => _usuarioCliente ?? "default"; 
        set { _usuarioCliente = value ?? "default"; }
        }
    public string RucUsuario {
        get => _rucUsuario ?? "default"; 
        set { _rucUsuario = value ?? "default"; }
        }

    // Datos intrínsicos
    public TipoUsuario TipoUsuario {
        get => _tipoUsuario ?? new TipoUsuario(); 
        set { _tipoUsuario = value ?? new TipoUsuario(); }
        }

    // Constructor
    public Usuario() {}

    private string? _nombreUsuario;
    private string? _usuarioCliente;
    private string? _rucUsuario;
    private TipoUsuario? _tipoUsuario;
}
