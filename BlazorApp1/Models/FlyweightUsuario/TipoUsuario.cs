namespace BlazorApp1.Models.FlyweightUsuario;

public class TipoUsuario
{
    // Contiene toda la información del usuario que tenga que
    // ver con el negocio en el que trabaja. [Datos intrínsicos]
    public int CodigoPerfil { 
        get => _codigoPerfil; 
        set{ _codigoPerfil = value;}
        }
    public string Perfil {
        get => _perfil ?? "default";
        set { _perfil = value ?? "default"; }  
        }  
    public string Estado {
        get => _estado ?? "default"; 
        set { _estado = value ?? "default"; }
        }
    public int Cargo {
        get => _cargo;
        set { _cargo = value; }
        }

    // Datos del Emisor.
    public int Emisor { 
        get => _emisor;
        set { _emisor = value; }
        }
    public string NombreEmisor {
        get => _nombreEmisor ?? "default";
        set { _nombreEmisor = value ?? "default"; }
        }
    // Datos de la Compañía.
    public int Compania {
        get => _compania;
        set { _compania = value; }
        }
    public string NombreCompania {
        get => _nombreCompania ?? "default";
        set { _nombreCompania = value ?? "default"; }
        }

    // Mensaje informativo referente al inicio de sesión del usuario.
    public string Observacion {
        get => _observacion ?? "default";
        set { _observacion = value ?? "default"; }
        } 

    // Constructor
    public TipoUsuario() {}

    private int _codigoPerfil;
    private string? _perfil;
    private string? _estado;
    private int _cargo;
    private int _emisor;
    private string? _nombreEmisor;
    private int _compania;
    private string? _nombreCompania;
    private string? _observacion;
}
