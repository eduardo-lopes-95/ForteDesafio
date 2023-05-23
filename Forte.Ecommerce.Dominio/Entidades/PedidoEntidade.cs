namespace Forte.Ecommerce.Dominio.Entidades;

public class PedidoEntidade : Entidade<PedidoEntidade>
{
    public int QuantidadeProdutos { get; set; }
    public decimal ValorTotalPedido { get; set; }
    public virtual ProdutoEntidade? Produto { get; set; }
    public virtual FornecedorEntidade? Fornecedor { get; set; }
}
