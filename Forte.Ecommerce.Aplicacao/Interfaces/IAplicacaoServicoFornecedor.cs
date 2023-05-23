using Forte.Ecommerce.Aplicacao.DTO;

namespace Forte.Ecommerce.Aplicacao.Interfaces;

public interface IAplicacaoServicoFornecedor
{
    FornecedorDTO GetById(Guid id);
    IEnumerable<FornecedorDTO> GetAll();
    void Add(FornecedorDTO obj);
    void Update(FornecedorDTO obj);
    void Remove(FornecedorDTO obj);
}
