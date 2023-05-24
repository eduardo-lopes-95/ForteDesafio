using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class Servico<TEntidade> : IServico<TEntidade> where TEntidade : Entidade
{
    private readonly IRepositorio<TEntidade> _repositorio;

    public Servico(IRepositorio<TEntidade> Repositorio)
    {
        _repositorio = Repositorio;
    }

    public IEnumerable<TEntidade> SelecionarTodos()
    {
        return _repositorio.SelecionarTodos();
    }

    public TEntidade SelecionarPorId(Guid id)
    {
        return _repositorio.SelecionarPorId(id);
    }
    public Guid Incluir(TEntidade obj)
    {
        return _repositorio.Incluir(obj);
    }

    public void Alterar(TEntidade obj)
    {
        _repositorio.Alterar(obj);
    }
    public void Excluir(Guid id)
    {
        _repositorio.Excluir(id);
    }
}
