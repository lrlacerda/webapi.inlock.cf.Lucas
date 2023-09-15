using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.cf.Lucas.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)] //Cria um indice único
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatório")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 á 20 caracteres")]
        public string Senha { get; set; }


        //referencia da chave estrangerira (tabela de estudio)
        [Required(ErrorMessage = "Tipo do usuário obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario TipoUsuario { get; set; }
    }
}
