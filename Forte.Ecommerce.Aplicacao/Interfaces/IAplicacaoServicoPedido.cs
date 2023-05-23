using Forte.Ecommerce.Aplicacao.DTO;

namespace Forte.Ecommerce.Aplicacao.Interfaces;

public interface IAplicacaoServicoPedido
{

    PedidoDTO GetById(Guid id);

    IEnumerable<PedidoDTO> GetAll();
    void Add(PedidoDTO obj);

    void Update(PedidoDTO obj);

    void Remove(PedidoDTO obj);
}
