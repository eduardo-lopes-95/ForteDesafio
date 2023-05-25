using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Aplicacao.Interfaces
{
    public interface IAplicacaoPedidoFornecedor<TEntidade, TEntidadeDTO>
        where TEntidade : Entidade
        where TEntidadeDTO : DTOBase
    {
        decimal TotalValorPedidoPorFornecedor(string cnpj);
    }
}
