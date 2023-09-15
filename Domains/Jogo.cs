using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.cf.Lucas.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        /// <summary>
        /// Classe que representa a entidade Jogo
        /// </summary>
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Jogo obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do Jogo obrigatório")]
        public string Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Lançamento do Jogo obrigatório")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Preço do Jogo obrigatório")]
        public decimal Preco { get; set; }

        //referencia da chave estrangerira (tabela de estudio)
        [Required(ErrorMessage = "Informe o Estúdio do Jogo")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio Estudio { get; set; }

    }
}
