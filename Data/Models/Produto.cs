using System.ComponentModel.DataAnnotations;

namespace SKEstoqueAPI.Data.Models
{
    public class Produto
    { 
        public int Id { get; set; }
        [MaxLength(120)]
        public string? DescricaoProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual List<Caracteristica>? Caracteristicas { get; set; }
    }
}
