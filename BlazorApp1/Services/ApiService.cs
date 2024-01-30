using BlazorApp1.Models;
using BlazorApp1.Models.FlyweightUsuario;
using Newtonsoft.Json;

namespace BlazorApp1.Services
{
    public class ApiService
    {
        //Atributos
        private static ApiService? _instancia;

        static HttpClient client = new HttpClient();

        private string _url = "http://apiservicios.ecuasolmovsa.com:3009/";

        //Constructor
        private ApiService() { }

        //Métodos
        public static ApiService Singleton()
        {
            if (_instancia == null)
            {
                _instancia = new ApiService();
            }
            return _instancia;
        }

        public async Task<List<Emisor>?> ObtenerEmisores()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(_url + "api/Varios/GetEmisor");
                if (response.IsSuccessStatusCode)
                {
                    // JSON como string
                    string json = await response.Content.ReadAsStringAsync();
                    // Deserializar el JSON a una lista 
                    List<Emisor>? datos = JsonConvert.DeserializeObject<List<Emisor>>(json);
                    if (datos != null) return datos;
                }
            } catch (Exception ex)
            {
                throw;
            }
            
            return null;
        }

public async Task<IEnumerable<Usuario>> ObtenerUsuarios(string user, string password)
{
    try
    {
        HttpResponseMessage response = await client.GetAsync(_url + $"api/Usuarios?usuario={user}&password={password}");
        // Verificar si la respuesta es exitosa
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            // Deserializa el JSON en una lista de tipos de usuarios
            var tiposUsuario = JsonConvert.DeserializeObject<List<TipoUsuario>>(json) 
                // En caso de que la lista sea nula, lanzar una excepción
                ?? throw new Exception("La lista de tipos de usuarios es nula");
            // Deserializa el JSON en una lista  de usuarios
            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) 
                // En caso de que la lista sea nula, lanzar una excepción
                ?? throw new Exception("La lista de usuarios es nula");

            // Fabrica los usuarios con sus respecctivos tipos de usuario
            usuarios = FabricaUsuario.FabricarUsuarios(usuarios, tiposUsuario);
            return usuarios;
        }
        else
        {
            // Maneja una respuesta inexistosa
            var errorResponse = await response.Content.ReadAsStringAsync();
            throw new Exception($"HTTP request failed with status code {response.StatusCode}. Error: {errorResponse}");
        }
    }
    catch (Exception ex)
    {
        // Regitra y envía el mensaje de error
        Console.WriteLine($"Error al obtener los usuarios: {ex.Message}");
        throw;
    }
}




    }
}
