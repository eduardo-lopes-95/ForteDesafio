namespace Forte.Ecommerce.Dominio.Entidades;

public abstract class Entidade<T>
{
    public Guid Id { get; protected set; }
    public DateTime CriadoEm { get; protected set; }
}
