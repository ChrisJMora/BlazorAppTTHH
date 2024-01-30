﻿namespace BlazorApp1.Models.FlyweightUsuario;

public class FabricaUsuario
{
    private readonly static List<TipoUsuario> _tipoUsuarios = new List<TipoUsuario>();
    public static TipoUsuario ObtenerTipoUsuario(TipoUsuario tipoUsuario)
    {
        var tipoUsuarioEncontrado = _tipoUsuarios.Find(tu => tu.Equals(tipoUsuario));
        if (tipoUsuarioEncontrado != null)
        {
            return tipoUsuarioEncontrado;
        }
        else
        {
            _tipoUsuarios.Add(tipoUsuario);
            return tipoUsuario;
        }
    }

    public static Usuario FabricarUsuario(Usuario usuario, TipoUsuario tipoUsuario)
    {
        usuario.TipoUsuario = ObtenerTipoUsuario(tipoUsuario);
        return usuario;
    }

    public static List<Usuario> FabricarUsuarios(List<Usuario> usuarios, List<TipoUsuario> tiposUsuario)
    {
        var usuariosEncontrados = new List<Usuario>();
        for(int i = 0; i < usuarios.Count; i++)
        {
            usuariosEncontrados.Add(FabricarUsuario(usuarios[i], tiposUsuario[i]));
        }
        return usuariosEncontrados;
    }

}