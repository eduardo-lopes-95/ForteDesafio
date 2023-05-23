using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Data.Repositorios;

public class RepositorioPedido : Repositorio<PedidoEntidade>, IRepositorioPedido
{
    public RepositorioPedido(Contexto contexto) : base(contexto)
    {
    }
}
