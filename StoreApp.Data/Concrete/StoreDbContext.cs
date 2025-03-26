using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(e => e.Categories)
            .WithMany(e => e.Products)
            .UsingEntity<ProductCategory>();

        
        modelBuilder.Entity<Category>()
            .HasIndex(u => u.Url)
            .IsUnique();


        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new() { Id = 1, Name = "Samsung S24", Price = 40000, Description = "guzel telefon"},
                new() { Id = 2, Name = "Samsung S25", Price = 50000, Description = "guzel telefon" },
                new() { Id = 3, Name = "Samsung S26", Price = 60000, Description = "guzel telefon" },
                new() { Id = 4, Name = "Samsung S27", Price = 70000, Description = "guzel telefon" },
                new() { Id = 5, Name = "Samsung S28", Price = 80000, Description = "guzel telefon" },
                new() { Id = 6, Name = "Samsung S29", Price = 90000, Description = "guzel telefon" },
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new List<Category>
            {
                new() { Id = 1, Name = "Telefon", Url = "telefon" },
                new() { Id = 2, Name = "Bilgisayar", Url = "bilgisayar" },
                new() { Id = 3, Name = "Elektronik", Url = "elektronik" },
                new() { Id = 4, Name = "Beyaz Esya", Url = "beyaz-esya" },
                new() { Id = 5, Name = "Moda", Url = "moda" },
                new() { Id = 6, Name = "Kitap", Url = "kitap" },
            }
        );

        modelBuilder.Entity<ProductCategory>().HasData(
            new List<ProductCategory>
            {
                new() { CategoryId = 1, ProductId = 1 },
                new() { CategoryId = 3, ProductId = 1 },
                new() { CategoryId = 1, ProductId = 2 },
                new() { CategoryId = 1, ProductId = 3 },
                new() { CategoryId = 1, ProductId = 4 },
                new() { CategoryId = 2, ProductId = 5 },
                new() { CategoryId = 2, ProductId = 6 },
            }
        );

    }
}