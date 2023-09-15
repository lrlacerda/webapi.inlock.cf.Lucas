using Microsoft.EntityFrameworkCore;
using webapi.inlock.cf.Lucas.Domains;

namespace webapi.inlock.cf.Lucas.Contexts
{
    public class InlockContext : DbContext
    {
        //Define a entidades de dados
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as ações de construção do banco (string Conexão)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE06-S15; DataBase=inlock_games_codeFirst_Lucas; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
