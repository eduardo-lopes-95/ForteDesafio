using Forte.Ecommerce.Dominio.Entidades;
using Forte.Ecommerce.Infraestrutura.Data.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Forte.Ecommerce.Infraestrutura.Data.Contextos;

public class Contexto : DbContext
{
    public DbSet<FornecedorEntidade> Fornecedores { get; set; }
    public DbSet<ProdutoEntidade> Produtos { get; set; }
    public DbSet<PedidoEntidade> Pedidos { get; set; }
    public IDbContextTransaction Transaction { get; private set; }

    public Contexto(DbContextOptions<Contexto> options)
            : base(options)
    {
        if (Database.GetPendingMigrations().Count() > 0)
            Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    public IDbContextTransaction InitTransacao()
    {
        if (Transaction == null) Transaction = this.Database.BeginTransaction();
        return Transaction;
    }


    private void RollBack()
    {
        if (Transaction != null)
        {
            Transaction.Rollback();
        }
    }

    private void Salvar()
    {
        try
        {
            ChangeTracker.DetectChanges();
            SaveChanges();
        }
        catch (Exception ex)
        {
            RollBack();
            throw new Exception(ex.Message);
        }
    }

    private void Commit()
    {
        if (Transaction != null)
        {
            Transaction.Commit();
            Transaction.Dispose();
            Transaction = null;
        }
    }

    public void SendChanges()
    {
        Salvar();
        Commit();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new MapFornecedor());
        modelBuilder.ApplyConfiguration(new MapProduto());
        modelBuilder.ApplyConfiguration(new MapPedido());
    }

}
