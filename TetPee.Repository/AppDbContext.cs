using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;

namespace TetPee.Repository;

public class AppDbContext : DbContext//là một thằng đại diện cho db
//kế thừa từ DbContext của EF Core
//AppContext = cầu nối giữa C# code với DB
//EF core ko làm việc trực tiếp với DB mà thông qua DbContext
/*
 _dbContext.Users.Add(user);
_dbContext.SaveChanges();
Thì thực chất:
EF Core nhìn vào AppDbContext
Biết:
Có bảng Users
Mapping với entity User
Rồi tự sinh SQL để chạy vào DB
 */

{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }
    
    public DbSet<User> Users  { get; set; }
    public DbSet<Seller> Sellers  { get; set; }
    public DbSet<Product> Products  { get; set; }
    public DbSet<ProductStorage> ProductStorages  { get; set; }
    public DbSet<Storage> Storages  { get; set; }
    public DbSet<Cart> Carts  { get; set; }
    public DbSet<Inventory> Inventories  { get; set; }
    public DbSet<Order> Orders  { get; set; }
    public DbSet<OrderDetail> OrderDetails  { get; set; }
    public DbSet<ProductCategory> ProductCategories  { get; set; }
    public DbSet<Category> Categories  { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuider)
    {
    }
}