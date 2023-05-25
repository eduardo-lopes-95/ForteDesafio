namespace Forte.Ecommerce.Dominio.Entidades;

public class PedidoEntidade : Entidade
{
    public string Codigo { get; set; } = string.Empty;
    public int QuantidadeProdutos { get; set; }
    public decimal ValorTotalPedido { get; set; }
    public Guid FornecedorId { get; set; }
    public FornecedorEntidade? Fornecedor { get; set; }
    public ICollection<ProdutoEntidade> Produtos { get; set; } = new List<ProdutoEntidade>();
    
}
