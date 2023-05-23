using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoFornecedor : Servico<FornecedorEntidade>, IServicoFornecedor
{
    public ServicoFornecedor(IRepositorio<FornecedorEntidade> Repositorio) : base(Repositorio)
    {
    }
}
