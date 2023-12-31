﻿using BlazorApp1.Models;
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

        public async Task<List<Emisor>?> ObtenerEmisores()
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
            return null;
        }

<<<<<<< HEAD
        public async Task<Usuario?> ObtenerUsuario(String user,String password)
        {
            HttpResponseMessage response = await client.GetAsync(_url + $"api/Usuarios?usuario={user}&password={password}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Usuario? datos = JsonConvert.DeserializeObject<Usuario>(json);
                if (datos != null) return datos;
            }
            return null;
        }
=======

>>>>>>> b75ce1a1b6af9812190ff65d525c924f9655986f

    }
}
