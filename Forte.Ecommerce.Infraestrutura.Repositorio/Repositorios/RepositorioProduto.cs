using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Repositorio.Repositorios;

public class RepositorioProduto : Repositorio<ProdutoEntidade>, IRepositorioProduto
{
    private readonly SqlContext _context;

    public RepositorioProduto(SqlContext context) : base(context)
    {
        _context = context;
    }
}
