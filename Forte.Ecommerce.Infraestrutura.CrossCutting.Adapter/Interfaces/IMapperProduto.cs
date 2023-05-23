using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Infraestrutura.CrossCutting.Adapter.Interfaces;

public interface IMapperProduto
{
    ProdutoEntidade MapperToEntity(ProdutoDTO produtoDTO);

    IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<ProdutoEntidade> produtos);

    ProdutoDTO MapperToDTO(ProdutoEntidade Produto);
}
