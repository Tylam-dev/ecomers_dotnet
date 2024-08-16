using Microsoft.EntityFrameworkCore;

namespace ecomers_dotnet;

public class dbContextEcomers: DbContext
{
    public DbSet<Categories> Categories {get;set;}
    public DbSet<Orders> Orders {get;set;}
    public DbSet<Products> Products {get;set;}
    public DbSet<ProductsOrders> ProductOrder {get;set;}
    public DbSet<Roles> Roles {get;set;}
    public DbSet<Users> Users {get;set;}
    public dbContextEcomers(DbContextOptions<dbContextEcomers> options): base(options){}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categories>(category => {
            category.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            category.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            category.HasMany(p => p.Products).WithOne(p => p.Category);
        });
        modelBuilder.Entity<Roles>(role => {
            role.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            role.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            role.HasMany(p => p.Users).WithOne(p => p.Role);
            });
        modelBuilder.Entity<Users>(user => {
            user.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            user.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
        modelBuilder.Entity<Orders>(order => {
            order.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            order.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            order.HasOne(p => p.Users).WithMany(p => p.Orders);
        });
        modelBuilder.Entity<Products>(product => {
            product.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            product.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
        modelBuilder.Entity<ProductsOrders>(productOrder => {
            productOrder.HasOne(p => p.Order).WithMany(p => p.ProductsOrders);
            productOrder.HasOne(p => p.Product).WithMany(p => p.ProductsOrders);
            productOrder.Property(p => p.CreationDate).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            productOrder.Property(p => p.UpdateDate).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}
