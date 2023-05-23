using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoFornecedor : Servico<FornecedorEntidade>, IServicoFornecedor
{
    public readonly IRepositorioFornecedor _repositorioFornecedor;

    public ServicoFornecedor(IRepositorioFornecedor repositorioFornecedor) : base(repositorioFornecedor)
    {
        _repositorioFornecedor = repositorioFornecedor;
    }
}
