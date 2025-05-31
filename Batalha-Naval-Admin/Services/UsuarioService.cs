using Batalha_Naval_Admin.Models;

namespace Batalha_Naval_Admin.Services{
    public class UsuarioService
    {
        //private readonly HttpClient _http;
        
        //public UsuarioService(HttpClient http)
        //{
        //    _http = http;
        //}

        public async Task<UsuarioModel>GetUsuarioAsync(UsuarioModel usuario)
        {
            usuario.Id = 1;

            return usuario;
        }
    }
}
