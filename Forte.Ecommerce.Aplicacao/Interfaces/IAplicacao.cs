using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Aplicacao.Interfaces;

public interface IAplicacao<TEntidade, TEntidadeDTO>
        where TEntidade : Entidade
        where TEntidadeDTO : DTOBase
{
    TEntidadeDTO SelecionarPorId(Guid id);
    IEnumerable<TEntidadeDTO> SelecionarTodos();
    Guid Incluir(TEntidadeDTO obj);
    void Alterar(TEntidadeDTO obj);
    void Excluir(Guid id);
}

