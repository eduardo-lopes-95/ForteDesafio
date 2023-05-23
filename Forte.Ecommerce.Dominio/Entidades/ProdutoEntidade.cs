namespace Forte.Ecommerce.Dominio.Entidades;

public class ProdutoEntidade : Entidade
{
    public string Nome { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorProduto { get; set; }
    public Guid ProdutoId { get; set; }
    public virtual PedidoEntidade Pedido { get; set; } = new PedidoEntidade();
    public virtual FornecedorEntidade? Fornecedor { get; set; } = new FornecedorEntidade();

}
