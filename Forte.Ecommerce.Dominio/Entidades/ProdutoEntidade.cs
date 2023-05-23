namespace Forte.Ecommerce.Dominio.Entidades;

public class ProdutoEntidade : Entidade<ProdutoEntidade>
{
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorProduto { get; set; }
}
