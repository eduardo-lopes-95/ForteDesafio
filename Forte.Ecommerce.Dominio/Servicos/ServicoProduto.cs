using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Servicos;

namespace Forte.Ecommerce.Dominio.Interfaces.Servicos;

public class ServicoProduto : Servico<ProdutoEntidade>, IServicoProduto
{
    public ServicoProduto(IRepositorio<ProdutoEntidade> Repositorio) : base(Repositorio)
    {
    }
}
