using AutoMapper;
using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Aplicacao;

public class MappingEntidade : Profile
{
    public MappingEntidade()
    {
        CreateMap<FornecedorEntidade, FornecedorDTO>().ReverseMap();
        CreateMap<ProdutoEntidade, ProdutoDTO>().ReverseMap();
        CreateMap<PedidoEntidade, PedidoDTO>().ReverseMap();
    }
}
