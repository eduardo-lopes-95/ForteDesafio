using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Dominio.Servicos;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServicoPedido : IAplicacaoServicoPedido
{
    private readonly IServicoPedido _ServicoPedido;
    private readonly IMapperPedido _mapperPedido;

    public AplicacaoServicoPedido(IServicoPedido ServicoPedido, IMapperPedido mapperPedido)
    {
        _ServicoPedido = ServicoPedido;
        _mapperPedido = mapperPedido;
    }
    public PedidoDTO GetById(Guid id)
    {
        var objPedido = _ServicoPedido.GetById(id);
        return _mapperPedido.MapperToDTO(objPedido);
    }
    public IEnumerable<PedidoDTO> GetAll()
    {
        var objProdutos = _ServicoPedido.GetAll();
        return _mapperPedido.MapperListPedidos(objProdutos);
    }
    public void Add(PedidoDTO obj)
    {
        var objPedido = _mapperPedido.MapperToEntity(obj);
        _ServicoPedido.Add(objPedido);
    }
    public void Update(PedidoDTO obj)
    {
        var objPedido = _mapperPedido.MapperToEntity(obj);
        _ServicoPedido.Update(objPedido);
    }
    public void Remove(PedidoDTO obj)
    {
        var objPedido = _mapperPedido.MapperToEntity(obj);
        _ServicoPedido.Remove(objPedido);
    }
}
