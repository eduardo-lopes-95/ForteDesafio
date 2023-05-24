using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Api.Controllers
{
    public class PedidoFornecedorController : ControllerBase<PedidoEntidade, PedidoDTO>
    {
        public PedidoFornecedorController(IAplicacaoPedido aplicacao) : base(aplicacao)
        {
        }
    }
}
