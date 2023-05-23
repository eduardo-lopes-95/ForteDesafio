using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Dominio.Interfaces;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;
using Microsoft.EntityFrameworkCore;

namespace Forte.Ecommerce.Infraestrutura.Repositorio.Repositorios;

public class Repositorio<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : Entidade
{
    protected readonly Contexto contexto;

    public Repositorio(Contexto contexto)
        : base()
    {
        this.contexto = contexto;
    }

    public void Alterar(TEntidade entidade)
    {
        contexto.InitTransacao();
        contexto.Set<TEntidade>().Attach(entidade);
        contexto.Entry(entidade).State = EntityState.Modified;
        contexto.SendChanges();
    }

    public void Excluir(Guid id)
    {
        var entidade = SelecionarPorId(id);
        if (entidade != null)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();
        }
    }

    public void Excluir(TEntidade entidade)
    {
        contexto.InitTransacao();
        contexto.Set<TEntidade>().Remove(entidade);
        contexto.SendChanges();
    }

    public Guid Incluir(TEntidade entidade)
    {
        contexto.InitTransacao();
        var id = contexto.Set<TEntidade>().Add(entidade).Entity.Id;
        contexto.SendChanges();
        return id;
    }

    public TEntidade SelecionarPorId(Guid id)
    {
        return contexto.Set<TEntidade>().Find(id);
    }

    public IEnumerable<TEntidade> SelecionarTodos()
    {
        return contexto.Set<TEntidade>().ToList();
    }
}
