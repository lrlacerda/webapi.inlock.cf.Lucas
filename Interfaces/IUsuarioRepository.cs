using webapi.inlock.cf.Lucas.Domains;

namespace webapi.inlock.cf.Lucas.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);
        void Cadastrar(Usuario usuario);
    }
}
