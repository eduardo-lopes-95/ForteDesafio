using Forte.Ecommerce.Aplicacao.DTO;
using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forte.Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerBase<TEntidade, EntidadeDTO> : Controller
        where TEntidade : Entidade
        where EntidadeDTO : DTOBase
    {
        private readonly IAplicacao<Entidade, DTOBase> aplicacao;

        public ControllerBase(IAplicacao<Entidade, DTOBase> aplicacao)
        {
            this.aplicacao = aplicacao;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var objetos = aplicacao.SelecionarTodos();
                return new OkObjectResult(objetos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(Guid Id)
        {
            try
            {
                var objeto = aplicacao.SelecionarPorId(Id);
                return new OkObjectResult(objeto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                return new OkObjectResult(aplicacao.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                aplicacao.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(Guid Id)
        {
            try
            {
                aplicacao.Excluir(Id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
