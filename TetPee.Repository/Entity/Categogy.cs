using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Categogy: BaseEntity<Guid>, IAuditableEntity
{
    public Guid ParentId { get; set; }
    public Categogy? Parent { get; set; }
    //nếu àm là null thì nó là thằng cha cao nhật 
    //nếu có giá trị thì nó là thg còn cuare paretn ID
    
    public ICollection<Categogy> Children { get; set; } = new List<Categogy>();
  
    public ICollection<ProductCategory>  Product_Cate { get; set; } = new List<ProductCategory>();

    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}