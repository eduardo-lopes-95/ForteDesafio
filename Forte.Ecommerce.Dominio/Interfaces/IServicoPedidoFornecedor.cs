namespace Forte.Ecommerce.Dominio.Interfaces;

public interface IServicoPedidoFornecedor
{
    decimal TotalValorPedidoPorFornecedor(string Codigo, Guid idFornecedor);
}
