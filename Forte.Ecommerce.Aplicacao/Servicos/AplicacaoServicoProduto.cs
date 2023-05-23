using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServicoProduto : IAplicacaoServicoProduto
{
    private readonly IServicoProduto _servicoProduto;
    private readonly IMapperProduto _mapperProduto;

    public AplicacaoServicoProduto(IServicoProduto servicoProduto, IMapperProduto mapperProduto)
    {
        _servicoProduto = servicoProduto;
        _mapperProduto = mapperProduto;
    }
    public ProdutoDTO GetById(Guid id)
    {
        var objProduto = _servicoProduto.GetById(id);
        return _mapperProduto.MapperToDTO(objProduto);
    }
    public IEnumerable<ProdutoDTO> GetAll()
    {
        var objProdutos = _servicoProduto.GetAll();
        return _mapperProduto.MapperListProdutos(objProdutos);
    }
    public void Add(ProdutoDTO obj)
    {
        var objProduto = _mapperProduto.MapperToEntity(obj);
        _servicoProduto.Add(objProduto);
    }
    public void Update(ProdutoDTO obj)
    {
        var objProduto = _mapperProduto.MapperToEntity(obj);
        _servicoProduto.Update(objProduto);
    }
    public void Remove(ProdutoDTO obj)
    {
        var objProduto = _mapperProduto.MapperToEntity(obj);
        _servicoProduto.Remove(objProduto);
    }
}
