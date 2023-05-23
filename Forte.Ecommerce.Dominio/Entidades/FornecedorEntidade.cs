namespace Forte.Ecommerce.Dominio.Entidades;

public class FornecedorEntidade : Entidade
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string RazaoSocial { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string Uf { get; set; } = string.Empty;
    public Guid ProdutoId { get; set; }
    public virtual ProdutoEntidade Produto { get; set; } = new ProdutoEntidade();
}
