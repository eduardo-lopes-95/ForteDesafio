using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServicoFornecedor : IAplicacaoServicoFornecedor
{
    private readonly IServicoFornecedor _servicoFornecedor;
    private readonly IMapperFornecedor _mapperFornecedor;

    public AplicacaoServicoFornecedor(IServicoFornecedor servicoFornecedor, IMapperFornecedor mapperFornecedor)
    {
        _servicoFornecedor = servicoFornecedor;
        _mapperFornecedor = mapperFornecedor;
    }
    public FornecedorDTO GetById(Guid id)
    {
        var objFornecedor = _servicoFornecedor.SelecionarPorId(id);
        return _mapperFornecedo.MapperToDTO(objFornecedor);
    }
    public IEnumerable<FornecedorDTO> GetAll()
    {
        var objProdutos = _servicoFornecedor.SelecioneTodos();
        return _mapperFornecedo.MapperListFornecedores(objProdutos);
    }
    public void Add(FornecedorDTO obj)
    {
        var objFornecedor = _mapperFornecedo.MapperToEntity(obj);
        _servicoFornecedor.Incluir(objFornecedor);
    }
    public void Update(FornecedorDTO obj)
    {
        var objFornecedor = _mapperFornecedo.MapperToEntity(obj);
        _servicoFornecedor.Alterar(objFornecedor);
    }
    public void Remove(FornecedorDTO obj)
    {
        var objFornecedor = _mapperFornecedo.MapperToEntity(obj);
        _servicoFornecedor.Excluir(objFornecedor);
    }
}
