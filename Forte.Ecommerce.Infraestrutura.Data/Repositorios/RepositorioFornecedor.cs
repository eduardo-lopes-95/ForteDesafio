using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Data.Repositorios;

public class RepositorioFornecedor : Repositorio<FornecedorEntidade>, IRepositorioFornecedor
{
    public RepositorioFornecedor(Contexto contexto) : base(contexto)
    {
    }
}
