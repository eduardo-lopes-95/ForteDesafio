using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Infraestrutura.CrossCutting.Adapter.Interfaces;

public interface IMapperPedido
{
    PedidoEntidade MapperToEntity(PedidoDTO PedidoDTO);

    IEnumerable<PedidoDTO> MapperListPedidos(IEnumerable<PedidoEntidade> Pedidos);

    PedidoDTO MapperToDTO(PedidoEntidade Pedido);
}
