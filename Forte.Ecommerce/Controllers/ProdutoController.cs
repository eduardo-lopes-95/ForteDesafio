using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Api.Controllers;

public class ProdutoController : ControllerBase<ProdutoEntidade, ProdutoDTO>
{
    public ProdutoController(IAplicacaoProduto aplicacao) : base(aplicacao)
    {
    }
}
