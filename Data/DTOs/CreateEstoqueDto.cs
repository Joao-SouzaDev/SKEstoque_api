using System.ComponentModel.DataAnnotations;

namespace SKEstoqueAPI.Data.DTOs
{
    public class CreateEstoqueDto
    {
        [MaxLength(120)]
        public required string DescricaoProduto { get; set; }
        public List<CreateCaracteristicaDto>? Caracteristicas { get; set; }
    }
}
