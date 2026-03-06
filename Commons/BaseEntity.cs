namespace Cp1Biblioteca.Domain.Commons;

public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; } = DateTime.Now;
}