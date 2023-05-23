using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoPedido : Servico<PedidoEntidade>, IServicoPedido
{
    public ServicoPedido(IRepositorio<PedidoEntidade> Repositorio) : base(Repositorio)
    {
    }
}
