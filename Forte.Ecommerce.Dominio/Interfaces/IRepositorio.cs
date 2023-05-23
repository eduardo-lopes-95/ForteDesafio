using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Dominio.Interfaces;

public interface IRepositorio<TEntity> where TEntity : class
{
    TEntity GetById(Guid Id);
    IEnumerable<TEntity> GetAll();
    void Add(TEntity obj);
    void Update(TEntity obj);
    void Remove(TEntity obj);
    Task Dispose();
}
