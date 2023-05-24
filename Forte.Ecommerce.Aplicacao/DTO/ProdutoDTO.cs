namespace Forte.Ecommerce.Aplicacao.DTO;

public class ProdutoDTO : DTOBase
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorProduto { get; set; }
}
