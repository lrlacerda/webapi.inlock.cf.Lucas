using webapi.inlock.cf.Lucas.Contexts;
using webapi.inlock.cf.Lucas.Domains;
using webapi.inlock.cf.Lucas.Interfaces;
using webapi.inlock.cf.Lucas.Utils;

namespace webapi.inlock.cf.Lucas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Variável privada e somente leitura para armazenar os dados do contexto
        /// </summary>
        private readonly InlockContext ctx;

        /// <summary>
        /// Construtor do repositório
        /// Toda vez que o repositório for instanciado
        /// Ele terá acesso aos dados fornecidos pelo context
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }

        public Usuario BuscarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
