using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Infraestrutura.CrossCutting.Adapter.Interfaces;

public interface IMapperFornecedor
{
    FornecedorEntidade MapperToEntity(FornecedorDTO FornecedorDTO);

    IEnumerable<FornecedorDTO> MapperListFornecedores(IEnumerable<FornecedorEntidade> fornecedores);

    FornecedorDTO MapperToDTO(FornecedorEntidade fornecedor);
}
