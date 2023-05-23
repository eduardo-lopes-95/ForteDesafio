namespace Forte.Ecommerce.Dominio.Interfaces;

public interface IRepositorio<TEntidade> where TEntidade : class
{
    TEntidade SelecionarPorId(Guid id);
    IEnumerable<TEntidade> SelecionarTodos();
    Guid Incluir(TEntidade entidade);
    void Excluir(Guid id);
    void Alterar(TEntidade entidade);
}
