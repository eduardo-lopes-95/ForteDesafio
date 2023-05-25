using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Forte.Ecommerce.Api.Controllers;

public class PedidoController : ControllerBase<PedidoEntidade, PedidoDTO>
{

    private readonly IServicoPedidoFornecedor servicoPedidoFornecedor;

    public PedidoController(IAplicacaoPedido aplicacao,
        IServicoPedidoFornecedor servicoPedidoFornecedor) : base(aplicacao)
    {
        this.servicoPedidoFornecedor = servicoPedidoFornecedor;
    }

    [HttpGet]
    [Route("TotalPedidoFornecedor")]
    public IActionResult ConsultaTotalPedidoPorFornecedor(string codigo, Guid idFornecedor)
    {
        return Ok(servicoPedidoFornecedor.TotalValorPedidoPorFornecedor(codigo, idFornecedor));
    }
}
