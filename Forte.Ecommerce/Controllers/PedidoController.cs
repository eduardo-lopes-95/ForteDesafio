using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Api.Controllers;

public class PedidoController : ControllerBase<PedidoEntidade, PedidoDTO>
{
    public PedidoController(IAplicacao<Entidade, DTOBase> aplicacao) : base(aplicacao)
    {
    }
}
