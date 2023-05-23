namespace Forte.Ecommerce.Dominio.Entidades;

public class PedidoEntidade : Entidade
{
    public int QuantidadeProdutos { get; set; }
    public decimal ValorTotalPedido { get; set; }
    public ICollection<ProdutoEntidade> Produtos { get; set; } = new List<ProdutoEntidade>();
    
}
