using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Data.Repositorios;

public class RepositorioProduto : Repositorio<ProdutoEntidade>, IRepositorioProduto
{
    public RepositorioProduto(Contexto contexto) : base(contexto)
    {
    }
}
