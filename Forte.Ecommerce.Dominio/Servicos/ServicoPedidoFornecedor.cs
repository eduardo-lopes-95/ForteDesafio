using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Dominio.Servicos;

public class ServicoPedidoFornecedor : IServicoPedidoFornecedor
{
    private readonly IRepositorioFornecedor repositorioFornecedor;

    public ServicoPedidoFornecedor(IRepositorioFornecedor repositorioFornecedor)
    {
        this.repositorioFornecedor = repositorioFornecedor;
    }

    public decimal TotalValorPedidoPorFornecedor(string Codigo, Guid idFornecedor)
    {
        var fornecedor = repositorioFornecedor.SelecionarPorId(idFornecedor);
        
        if(fornecedor != null)
        {
            var total = fornecedor
                            .Pedidos
                            .Where(p => p.Codigo == Codigo)
                            .Sum(p => p.ValorTotalPedido);
            return total;
        }

        return 0;
    }
}
