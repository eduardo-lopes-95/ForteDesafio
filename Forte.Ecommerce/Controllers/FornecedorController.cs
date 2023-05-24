using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;

namespace Forte.Ecommerce.Api.Controllers;

public class FornecedorController : ControllerBase<FornecedorEntidade, FornecedorDTO>
{
    public FornecedorController(IAplicacaoFornecedor aplicacao) : base(aplicacao)
    {
    }
}
