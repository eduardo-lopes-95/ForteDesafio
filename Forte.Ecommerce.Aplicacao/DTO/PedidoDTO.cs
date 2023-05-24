namespace Forte.Ecommerce.Aplicacao.DTO;

public class PedidoDTO : DTOBase
{
    public string Codigo { get; set; } = string.Empty;
    public int QuantidadeProdutos { get; set; }
    public decimal ValorTotalPedido { get; set; }
}
