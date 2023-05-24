using AutoMapper;
using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServico<TEntidade, TEntidadeDTO> : IAplicacao<TEntidade, TEntidadeDTO>
    where TEntidade: Entidade
    where TEntidadeDTO : DTOBase
{
    protected readonly IServico<TEntidade> servico;
    protected readonly IMapper iMapper;

    public AplicacaoServico(IServico<TEntidade> servico, IMapper iMapper)
    {
        this.servico = servico;
        this.iMapper = iMapper;
    }

    public Guid Incluir(TEntidadeDTO obj)
    {
        return servico.Incluir(iMapper.Map<TEntidade>(obj));
    }

    public IEnumerable<TEntidadeDTO> SelecionarTodos()
    {
        return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.SelecionarTodos());
    }

    public TEntidadeDTO SelecionarPorId(Guid id)
    {
        return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(id));
    }

    public void Excluir(Guid id)
    {
        servico.Excluir(id);
    }

    public void Alterar(TEntidadeDTO obj)
    {
        servico.Alterar(iMapper.Map<TEntidade>(obj));
    }
}
