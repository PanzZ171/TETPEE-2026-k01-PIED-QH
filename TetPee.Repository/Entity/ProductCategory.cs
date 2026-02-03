using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class ProductCategory: BaseEntity<Guid>, IAuditableEntity
{
    public Guid CatecogyId { get; set; }
    public Categogy Categogy { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}