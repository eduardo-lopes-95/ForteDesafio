using AutoMapper;
using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServicoFornecedor : AplicacaoServico<FornecedorEntidade, FornecedorDTO>, IAplicacaoFornecedor
{
    public AplicacaoServicoFornecedor(IServico<FornecedorEntidade> servico, IMapper iMapper) : base(servico, iMapper)
    {
    }
}
