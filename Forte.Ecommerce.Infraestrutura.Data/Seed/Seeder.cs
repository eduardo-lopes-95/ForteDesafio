using AutoFixture;
using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;

namespace Forte.Ecommerce.Infraestrutura.Data.Seed;

public static class Seeder
{
    public static void Seed(this Contexto contexto)
    {
        if(!contexto.Fornecedores.Any())
        {
            Fixture fixture = new Fixture();
            fixture.Customize<FornecedorEntidade>(f => f.Without(f => f.NomeCompleto));
            fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            List<FornecedorEntidade> fornecedores = fixture.CreateMany<FornecedorEntidade>(5).ToList();
            contexto.AddRange(fornecedores);
            contexto.SaveChanges();
        }
    }
}
