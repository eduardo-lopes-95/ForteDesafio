using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoProduto : Servico<ProdutoEntidade>, IServicoProduto
{
    public readonly IRepositorioProduto _repositorioProduto;

    public ServicoProduto(IRepositorioProduto repositorioProduto) : base(repositorioProduto)
    {
        _repositorioProduto = repositorioProduto;
    }
}
