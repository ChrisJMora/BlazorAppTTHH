using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<List<TipoOperacion>?> ObtenerEmisores()
        {
            HttpResponseMessage response = await client.GetAsync(_url + "api/Varios/TipoOperacion");
            if (response.IsSuccessStatusCode)
            {
                // JSON como string
                string json = await response.Content.ReadAsStringAsync();
                // Deserializar el JSON a una lista 
                List<TipoOperacion>? datos = JsonConvert.DeserializeObject<List<TipoOperacion>>(json);
                if (datos != null) return datos;
            }
            return null;
        }

    }
}
