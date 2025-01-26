namespace SKEstoqueAPI.Data.Models
{
    public class Caracteristica
    {
        public int Id { get; set; }
        public string? TipoCaracteristica { get; set; }
        public string? ValorCaracteristica { get; set; }
        public int ProdutoId { get; set; }
        public required Produto Produto { get; set; }

    }
}
