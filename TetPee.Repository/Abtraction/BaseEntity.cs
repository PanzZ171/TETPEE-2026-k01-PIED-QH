namespace TetPee.Repository.Abtraction;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
    
    public bool IsDeleted { get; set; }//để không bị sung đột nhưững relationship trong bảng
    // Soft Delete, trannh sung đột khóa ngoại (Foreign Key COnstraint
    
}