using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Servicos;

namespace Forte.Ecommerce.Dominio.Interfaces.Servicos;

public class ServicoProduto : Servico<ProdutoEntidade>, IServicoProduto
{
    public readonly IRepositorioProduto _repositorioProduto;

    public ServicoProduto(IRepositorioProduto repositorioProduto) : base(repositorioProduto)
    {
        _repositorioProduto = repositorioProduto;
    }
}
