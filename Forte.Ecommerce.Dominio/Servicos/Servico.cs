using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public abstract class Servico<TEntity> : IDisposable, IServico<TEntity> where TEntity : class
{
    private readonly IRepositorio<TEntity> _repositorio;

    protected Servico(IRepositorio<TEntity> Repositorio)
    {
        _repositorio = Repositorio;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _repositorio.GetAll();
    }

    public TEntity GetById(Guid id)
    {
        return _repositorio.GetById(id);
    }
    public virtual void Add(TEntity obj)
    {
        _repositorio.Add(obj);
    }

    public virtual void Update(TEntity obj)
    {
        _repositorio.Update(obj);
    }
    public virtual void Remove(TEntity obj)
    {
        _repositorio.Remove(obj);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
