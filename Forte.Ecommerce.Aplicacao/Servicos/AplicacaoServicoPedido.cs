using AutoMapper;
using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;

namespace Forte.Ecommerce.Aplicacao.Servicos;

public class AplicacaoServicoPedido : AplicacaoServico<PedidoEntidade, PedidoDTO>, IAplicacaoPedido
{
    public AplicacaoServicoPedido(IServico<PedidoEntidade> servico, IMapper iMapper) : base(servico, iMapper)
    {
    }
}