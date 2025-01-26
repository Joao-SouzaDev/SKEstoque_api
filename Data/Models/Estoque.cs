using System.ComponentModel.DataAnnotations;

namespace SKEstoqueAPI.Data.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public decimal PrecoVendaEsperado { get; set; }
        public required Produto Produto { get; set; }
        
    }
}
