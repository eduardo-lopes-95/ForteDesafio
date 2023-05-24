using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoPedido : Servico<PedidoEntidade>, IServicoPedido
{
    public readonly IRepositorioPedido _repositorioPedido;

    public ServicoPedido(IRepositorioPedido repositorioPedido) : base (repositorioPedido)
    {
        _repositorioPedido = repositorioPedido;
    }

    
}
