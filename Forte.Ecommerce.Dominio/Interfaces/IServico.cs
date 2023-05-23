namespace Forte.Ecommerce.Dominio.Interfaces
{
    public interface IServico<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}