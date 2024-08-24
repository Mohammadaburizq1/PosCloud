using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductBrand> ProductBrand { get; set; }
    public DbSet<ProductType> ProductType { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}