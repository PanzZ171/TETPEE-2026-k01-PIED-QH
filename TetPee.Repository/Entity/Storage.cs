using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Storage: BaseEntity<Guid>, IAuditableEntity
{
    public Decimal Price { get; set; }
    public required string Type { get; set; }//exxport, import
    
    public ICollection<Storage> Storages { get; set; } = new List<Storage>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}