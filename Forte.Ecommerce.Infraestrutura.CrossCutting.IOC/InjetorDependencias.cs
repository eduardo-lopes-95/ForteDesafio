using Forte.Ecommerce.Aplicacao.Interfaces;
using Forte.Ecommerce.Aplicacao.Servicos;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Dominio.Servicos;
using Forte.Ecommerce.Infraestrutura.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Forte.Ecommerce.Infraestrutura.CrossCutting.IOC;

public class InjetorDependencias
{
    public static void Registrar(IServiceCollection svcCollection)
    {
        //Aplicação
        svcCollection.AddScoped(typeof(IAplicacao<,>), typeof(AplicacaoServico<,>));
        svcCollection.AddScoped<IAplicacaoFornecedor, AplicacaoServicoFornecedor>();
        svcCollection.AddScoped<IAplicacaoProduto, AplicacaoServicoProduto>();
        svcCollection.AddScoped<IAplicacaoPedido, AplicacaoServicoPedido>();

        //Domínio
        svcCollection.AddScoped(typeof(IServico<>), typeof(Servico<>));
        svcCollection.AddScoped<IServicoFornecedor, ServicoFornecedor>();
        svcCollection.AddScoped<IServicoProduto, ServicoProduto>();
        svcCollection.AddScoped<IServicoPedido, ServicoPedido>();

        //Repositorio
        svcCollection.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
        svcCollection.AddScoped<IRepositorioFornecedor, RepositorioFornecedor>();
        svcCollection.AddScoped<IRepositorioProduto, RepositorioProduto>();
        svcCollection.AddScoped<IRepositorioPedido, RepositorioPedido>();
    }
}
