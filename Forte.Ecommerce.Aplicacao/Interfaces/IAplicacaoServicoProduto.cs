using Forte.Ecommerce.Aplicacao.DTO;

namespace Forte.Ecommerce.Aplicacao.Interfaces;

public interface IAplicacaoServicoProduto
{

    ProdutoDTO GetById(Guid id);

    IEnumerable<ProdutoDTO> GetAll();
    void Add(ProdutoDTO obj);

    void Update(ProdutoDTO obj);

    void Remove(ProdutoDTO obj);
}
