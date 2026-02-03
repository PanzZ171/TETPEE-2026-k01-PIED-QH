using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;

namespace TetPee.Repository;

public class AppDbContext : DbContext
{
    //l 1 class qyaurn trọng của Entity frameworrk nó là đại dineej cho database
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User>  Users { get; set; }
    public DbSet<Product>  Products { get; set; }
    public DbSet<ProductCategory>  ProductCategories { get; set; }
    public DbSet<Cart>  Carts { get; set; }
    public DbSet<Order>  Orders { get; set; }
    public DbSet<OrderDetail>  OrderDetails { get; set; }
    public DbSet<Seller>  Sellers { get; set; }
    public DbSet<Inventories>  Inventories { get; set; }
    public DbSet<ProductStorage> ProductStorages { get; set; }
    public DbSet<Categogy> Categogies { get; set; }
    public DbSet<Storage> Storages { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}