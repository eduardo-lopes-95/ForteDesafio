namespace Forte.Ecommerce.Dominio.Entidades;

public class FornecedorEntidade : Entidade<FornecedorEntidade>
{
    public string RazaoSocial { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string Uf { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string NomeCompleto { get; set; } = string.Empty;
}
