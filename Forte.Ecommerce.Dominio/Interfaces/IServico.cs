namespace Forte.Ecommerce.Dominio.Interfaces
{
    public interface IServico<TEntidade> where TEntidade : class
    {
        TEntidade SelecionarPorId(Guid id);
        IEnumerable<TEntidade> SelecioneTodos();
        Guid Incluir(TEntidade entidade);
        void Alterar(TEntidade obj);
        void Excluir(Guid id);
    }
}