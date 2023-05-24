using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Dominio.Interfaces
{
    public interface IServico<TEntidade> where TEntidade : Entidade
    {
        TEntidade SelecionarPorId(Guid id);
        IEnumerable<TEntidade> SelecionarTodos();
        Guid Incluir(TEntidade entidade);
        void Alterar(TEntidade obj);
        void Excluir(Guid id);
    }
}