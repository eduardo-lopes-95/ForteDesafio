using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Repositorio.Repositorios;

public class RepositorioPedido : Repositorio<PedidoEntidade>, IRepositorioPedido
{
    private readonly SqlContext _context;

    public RepositorioPedido(SqlContext context) : base(context)
    {
        _context = context;
    }
}
